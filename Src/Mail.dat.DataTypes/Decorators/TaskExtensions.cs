namespace Mail.dat
{
	public static class TaskExtensions
	{
		public static Task MultipleActionsAsync(this MaildatEntity maildatEntity, params IEnumerable<Action> actions)
		{
			Task.WaitAll(actions.Select(a => Task.Run(a)).ToArray());
			return Task.CompletedTask;
		}
	}
}
