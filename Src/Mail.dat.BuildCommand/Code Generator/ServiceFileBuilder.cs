namespace Mail.dat.BuildCommand
{
	public class AssemblyReferenceBuilder : ICodeBuilder<AssemblyReferenceBuilder>
	{
		public string ObjectName { get; internal set; }
		public string NameSpace { get; internal set; }
		public string Assembly { get; internal set; }

		public static AssemblyReferenceBuilder Create(string objectName, string nameSpace, string assembly)
		{
			return new AssemblyReferenceBuilder()
			{
				ObjectName = objectName,
				NameSpace = nameSpace,
				Assembly = assembly
			};
		}

		public static AssemblyReferenceBuilder Create(string objectName)
		{
			return new AssemblyReferenceBuilder()
			{
				ObjectName = objectName,
				NameSpace = null,
				Assembly = null
			};
		}

		public AssemblyReferenceBuilder SetObjectName(string objectName)
		{
			this.ObjectName = objectName;
			return this;
		}

		public AssemblyReferenceBuilder SetNameSpace(string nameSpace)
		{
			this.NameSpace = nameSpace;
			return this;
		}

		public AssemblyReferenceBuilder SetAssembly(string assembly)
		{
			this.Assembly = assembly;
			return this;
		}

		public AssemblyReferenceBuilder Build(string filePath, int indentLevel = 0)
		{
			if (this.NameSpace != null && this.Assembly != null)
			{
				File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}{this.NameSpace}.{this.ObjectName}, {this.Assembly}");
			}
			else
			{
				//
				// Append as an alias refernce.
				//
				File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}<{this.ObjectName}>");
			}

			return this;
		}
	}

	public class AliasBuilder : ICodeBuilder<AliasBuilder>
	{
		public string Key { get; internal set; }
		public AssemblyReferenceBuilder TypeDefinition { get; internal set; }

		public static AliasBuilder Create(string key, AssemblyReferenceBuilder typeDefinition)
		{
			return new AliasBuilder()
			{
				Key = key,
				TypeDefinition = typeDefinition
			};
		}

		public AliasBuilder SetKey(string key)
		{
			this.Key = key;
			return this;
		}

		public AliasBuilder SetTypeDefinition(AssemblyReferenceBuilder typeDefinition)
		{
			this.TypeDefinition = typeDefinition;
			return this;
		}

		public AliasBuilder Build(string filePath, int indentLevel = 0)
		{
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}{{"]);
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)}\"Key\": \"{this.Key}\","]);
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel + 1)}\"TypeDefinition\": \"");
			this.TypeDefinition.Build(filePath, 0);
			File.AppendAllLines(filePath, ["\""]);
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}}}");

			return this;
		}
	}

	public class ServiceBuilder : ICodeBuilder<ServiceBuilder>
	{
		public AssemblyReferenceBuilder ServiceType { get; internal set; }
		public AssemblyReferenceBuilder ImplementationType { get; internal set; }
		public string Lifetime { get; internal set; }

		public static ServiceBuilder Create(AssemblyReferenceBuilder serviceType, AssemblyReferenceBuilder implementationType, string lifetime)
		{
			return new ServiceBuilder()
			{
				ServiceType = serviceType,
				ImplementationType = implementationType,
				Lifetime = lifetime
			};
		}

		public ServiceBuilder SetServiceType(AssemblyReferenceBuilder serviceType)
		{
			this.ServiceType = serviceType;
			return this;
		}

		public ServiceBuilder SetImplementationType(AssemblyReferenceBuilder implementationType)
		{
			this.ImplementationType = implementationType;
			return this;
		}

		public ServiceBuilder SetLifetime(string lifetime)
		{
			this.Lifetime = lifetime;
			return this;
		}

		public ServiceBuilder Build(string filePath, int indentLevel = 0)
		{
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel)}{{"]);
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel + 1)}\"ServiceType\": \"");
			this.ServiceType.Build(filePath, 0);
			File.AppendAllLines(filePath, ["\","]);
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel + 1)}\"ImplementationType\": \"");
			this.ImplementationType.Build(filePath, 0);
			File.AppendAllLines(filePath, ["\","]);
			File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)}\"Lifetime\": \"{this.Lifetime}\""]);
			File.AppendAllText(filePath, $"{Tabs.Create(indentLevel)}}}");

			return this;
		}
	}

	public class ServiceFileBuilder : ICodeBuilder<ServiceFileBuilder>
	{
		public List<AliasBuilder> Aliases { get; } = [];
		public List<ServiceBuilder> Services { get; } = [];

		public static ServiceFileBuilder Create()
		{
			return new ServiceFileBuilder();
		}

		public ServiceFileBuilder AddAlias(AliasBuilder alias)
		{
			this.Aliases.Add(alias);
			return this;
		}

		public ServiceFileBuilder AddAliases(params List<AliasBuilder> aliases)
		{
			this.Aliases.AddRange(aliases);
			return this;
		}

		public ServiceFileBuilder AddService(ServiceBuilder service)
		{
			this.Services.Add(service);
			return this;
		}

		public ServiceFileBuilder AddServices(params List<ServiceBuilder> services)
		{
			this.Services.AddRange(services);
			return this;
		}

		public ServiceFileBuilder Build(string filePath, int indentLevel = 0)
		{
			File.WriteAllLines(filePath, ["{"]);

			//
			// Append the aliases section.
			//
			if (this.Aliases.Count > 0)
			{
				File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)}\"aliases\": ["]);

				foreach (AliasBuilder alias in this.Aliases)
				{
					alias.Build(filePath, indentLevel + 2);

					if (alias != this.Aliases.Last())
					{
						File.AppendAllLines(filePath, [","]);
					}
					else
					{
						File.AppendAllLines(filePath, [""]);
					}
				}

				File.AppendAllText(filePath, $"{Tabs.Create(indentLevel + 1)}]");
			}

			//
			// Append the services section.
			//
			if (this.Services.Count > 0)
			{
				if (this.Aliases.Count > 0)
				{
					File.AppendAllLines(filePath, [","]);
				}
				else
				{
					File.AppendAllLines(filePath, [""]);
				}

				File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)}\"services\": ["]);

				foreach (ServiceBuilder service in this.Services)
				{
					service.Build(filePath, indentLevel + 2);

					if (service != this.Services.Last())
					{
						File.AppendAllLines(filePath, [","]);
					}
					else
					{
						File.AppendAllLines(filePath, [""]);
					}
				}

				File.AppendAllLines(filePath, [$"{Tabs.Create(indentLevel + 1)}]"]);
			}

			File.AppendAllLines(filePath, ["}"]);

			return this;
		}
	}
}