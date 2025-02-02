﻿using System.Configuration;
using System.Reflection;

namespace PSPublicMessagingAPI.Desktop.Services;

public class ConfigurationManagerService : IConfigurationManagerService
{
    private string userName;
    private string password;
    private string rbuserName;
    private string rbpassword;
    private string ou;
    private string connectionString;
    private bool silent;
    private bool mainWindowIsOpen;
    private string domain;
    private string aboutTitle;
    private string aboutText;
    private string host;
    private string signalHost;
    private string port;

    Configuration configuration { get; set; }
    public string RBUserName
    {
        get => configuration.AppSettings.Settings["rabbitusername"].Value;
        set
        {
            rbuserName = value;
            configuration.AppSettings.Settings["rabbitusername"].Value = rbuserName;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string RBPassword
    {
        get => configuration.AppSettings.Settings["rabbitpassword"].Value;
        set
        {
            rbpassword = value;
            configuration.AppSettings.Settings["rabbitpassword"].Value = rbpassword;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
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
    public bool MainWindowIsOpen
    {
        get => configuration.AppSettings.Settings["mainWindowIsOpen"].Value.ToString().ToLower() == "true" ||
               configuration.AppSettings.Settings["mainWindowIsOpen"].Value.ToString().ToLower() == "false" ?
            bool.Parse(configuration.AppSettings.Settings["mainWindowIsOpen"].Value.ToString().ToLower()) : false;
        set
        {
            mainWindowIsOpen = value;
            configuration.AppSettings.Settings["mainWindowIsOpen"].Value = mainWindowIsOpen.ToString().ToLower();
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
    public string SignalHost
    {
        get => configuration.AppSettings.Settings["signalhost"].Value;
        set
        {
            signalHost = value;
            configuration.AppSettings.Settings["signalhost"].Value = signalHost;
            configuration.Save();

            // Reload app config file
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
    public string Port
    {
        get => configuration.AppSettings.Settings["port"].Value;
        set
        {
            port = value;
            configuration.AppSettings.Settings["port"].Value = port;
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