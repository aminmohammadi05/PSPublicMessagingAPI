using System.Configuration;
using System.Reflection;

namespace PSPublicMessagingAPI.Desktop.Services;

public class ConfigurationManagerService : IConfigurationManagerService
{
    private string userName;
    private string password;
    private string ou;
    private string connectionString;
    private bool silent;
    private string domain;
    private string aboutTitle;
    private string aboutText;
    private string host;

    Configuration configuration { get; set; }
    public string UserName
    {
        get => configuration.AppSettings.Settings["username"].Value;
        set
        {
            userName = value;
            configuration.AppSettings.Settings["username"].Value = userName;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string Password
    {
        get => configuration.AppSettings.Settings["password"].Value;
        set
        {
            password = value;
            configuration.AppSettings.Settings["password"].Value = password;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string OU
    {
        get => configuration.AppSettings.Settings["ou"].Value;
        set
        {
            ou = value;
            configuration.AppSettings.Settings["ou"].Value = ou;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string ConnectionString
    {
        get => configuration.ConnectionStrings.ConnectionStrings["NotificationDB"].ToString();
        set
        {
            connectionString = value;
        }
    }
    public bool Silent
    {
        get => configuration.AppSettings.Settings["silent"].Value.ToString().ToLower() == "true" ||
                configuration.AppSettings.Settings["silent"].Value.ToString().ToLower() == "false" ?
                bool.Parse(configuration.AppSettings.Settings["silent"].Value.ToString().ToLower()) : false;
        set
        {
            silent = value;
            configuration.AppSettings.Settings["silent"].Value = silent.ToString().ToLower();
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string Domain
    {
        get => configuration.AppSettings.Settings["domain"].Value;
        set
        {
            domain = value;
            configuration.AppSettings.Settings["domain"].Value = domain;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string AboutTitle
    {
        get => configuration.AppSettings.Settings["aboutTitle"].Value;
        set
        {
            aboutTitle = value;
            configuration.AppSettings.Settings["aboutTitle"].Value = aboutTitle;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string Host
    {
        get => configuration.AppSettings.Settings["host"].Value;
        set
        {
            host = value;
            configuration.AppSettings.Settings["host"].Value = host;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string AboutText
    {
        get => configuration.AppSettings.Settings["aboutText"].Value;
        set
        {
            aboutText = value;
            configuration.AppSettings.Settings["aboutText"].Value = aboutText;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public ConfigurationManagerService()
    {
        configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

    }

}