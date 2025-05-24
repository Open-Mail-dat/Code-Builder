namespace Mail.dat
{
	/// <summary>
	/// Provides a set of methods that can be performed on any <see cref="IPlatinumEntity"/>
	/// entity model.
	/// </summary>
	public static class MaildatEntityDecorator
	{
		/// <summary>
		/// Sets the modified fields with the current date/time and the current user for the
		/// specified list of entity models.
		/// </summary>
		/// <typeparam name="TEntity">Specifies the entity type being modified.</typeparam>
		/// <param name="items">An <see cref="IEnumerable{TEntity}"/> list of entity models to update.</param>
		/// <param name="userName">Specifies the name of the user to write to the database.</param>
		/// <returns>Returns a reference to the original list.</returns>
		public static IEnumerable<TEntity> Touch<TEntity>(this IEnumerable<TEntity> items, string userName = null)
			where TEntity : IMaildatEntity
		{
			foreach (TEntity item in items)
			{
				item.Touch(userName);
			}

			return items;
		}

		/// <summary>
		/// Sets the modified fields with the current date/time and the current user for the
		/// specified list of entity models.
		/// </summary>
		/// <typeparam name="TEntity">Specifies the entity type being modified.</typeparam>
		/// <param name="items">An <see cref="IEnumerable{TEntity}"/> list of entity models to update.</param>
		/// <param name="userName">Specifies the name of the user to write to the database.</param>
		/// <returns>Returns a reference to the original list.</returns>
		public static Task<IEnumerable<TEntity>> TouchAsync<TEntity>(this IEnumerable<TEntity> items, string userName = null)
			where TEntity : IMaildatEntity
		{
			foreach (TEntity item in items)
			{
				item.Touch();
			}

			return Task.FromResult(items);
		}

		/// <summary>
		/// Sets the created and modified fields with the current date/time and the
		/// current user.
		/// </summary>
		/// <typeparam name="TEntity">Specifies the entity type being modified.</typeparam>
		/// <param name="item"></param>
		/// <returns>Returns a reference to the original entity model.</returns>
		public static TEntity Touch<TEntity>(this TEntity item)
			where TEntity : IMaildatEntity
		{
			return item.Touch(DbEnvironment.CurrentUser);
		}

		/// <summary>
		/// Sets the created and modified fields with the current date/time and the
		/// current user.
		/// </summary>
		/// <typeparam name="TEntity">Specifies the entity type being modified.</typeparam>
		/// <param name="item"></param>
		/// <returns>Returns a reference to the original entity model.</returns>
		public static Task<TEntity> TouchAsync<TEntity>(this TEntity item)
			where TEntity : IMaildatEntity
		{
			return Task.FromResult(item.Touch(DbEnvironment.CurrentUser));
		}

		/// <summary>
		/// Sets the created and modified fields with the current date/time and the
		/// current user.
		/// </summary>
		/// <typeparam name="TEntity">Specifies the entity type being modified.</typeparam>
		/// <param name="item"></param>
		/// <param name="userName">Specifies the name of the user to write to the database.</param>
		/// <returns>Returns a reference to the original entity model.</returns>
		public static TEntity Touch<TEntity>(this TEntity item, string userName)
			where TEntity : IMaildatEntity
		{
			//
			// Do not override an existing value.
			//
			if (string.IsNullOrWhiteSpace(item.CreatedBy))
			{
				item.CreatedBy = userName ?? DbEnvironment.CurrentUser;
			}

			//
			// Do not override an existing value.
			//
			if (item.CreatedDateTime == DateTimeOffset.MinValue)
			{
				item.CreatedDateTime = DateTimeOffset.Now;
			}

			item.ModifiedBy = userName ?? DbEnvironment.CurrentUser;
			item.ModifiedDateTime = DateTimeOffset.Now;

			return item;
		}

		/// <summary>
		/// Sets the created and modified fields with the current date/time and the
		/// current user.
		/// </summary>
		/// <typeparam name="TEntity">Specifies the entity type being modified.</typeparam>
		/// <param name="item"></param>
		/// <param name="userName">Specifies the name of the user to write to the database.</param>
		/// <returns>Returns a reference to the original entity model.</returns>
		public static Task<TEntity> TouchAsync<TEntity>(this TEntity item, string userName)
			where TEntity : IMaildatEntity
		{
			return item.TouchAsync(userName);
		}
	}
}
