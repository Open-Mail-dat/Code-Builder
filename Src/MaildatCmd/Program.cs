using Diamond.Core.CommandLine;
using Diamond.Core.Extensions.DependencyInjection;
using Diamond.Core.Extensions.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Mail.dat.Cmd
{
	/// <summary>
	/// 
	/// </summary>
	public class Program
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		static Task<int> Main(string[] args) => Host.CreateDefaultBuilder(args)
							.AddRootCommand("Mail.dat Command Line Utility", args)
							.UseStartup<ConsoleStartup>()
							.UseSerilog()
							.ConfigureServicesFolder("Services")
							.UseConfiguredServices()
							.UseConsoleLifetime()
							.Build()
							.RunWithExitCodeAsync();
	}
}
