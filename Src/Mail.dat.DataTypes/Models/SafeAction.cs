namespace Mail.dat
{
	public static class SafeExecutor
	{
		public static void Try(Action tryAction, Action<Exception> catchAction)
		{
			try
			{
				tryAction();
			}
			catch (Exception ex)
			{
				catchAction(ex);
			}
		}
	}
}
