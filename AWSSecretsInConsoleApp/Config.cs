namespace AWSSecretsInConsoleApp
{
    public class Config
	{
		public ConnectionDetails connectionDetails { get; set; }
	}

	public class ConnectionDetails
	{
		public string Database { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
