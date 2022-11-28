// See https://aka.ms/new-console-template for more information
using AWSSecretsInConsoleApp;
using Microsoft.Extensions.Configuration;
using System.Text;
IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
//pass AWS secrets to executable as environment variable
string data = Environment.GetEnvironmentVariable("Config");
if (!string.IsNullOrEmpty(data) && data.Trim() != "")
{
    MemoryStream newData = new(Encoding.Default.GetBytes(data));
    if (newData != null) configurationBuilder.AddJsonStream(newData);
}
IConfigurationRoot configurationRoot = configurationBuilder.Build();
Config? config = configurationRoot.GetSection("Config").Get<Config>();
Console.WriteLine("Database: " + config.connectionDetails.Database);
Console.WriteLine("Username: " + config.connectionDetails.Username);



