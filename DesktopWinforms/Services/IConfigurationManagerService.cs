﻿namespace PSPublicMessagingAPI.Desktop.Services;

public interface IConfigurationManagerService
{
    string UserName { get; set; }
    string Password { get; set; }
    string RBUserName { get; set; }
    string RBPassword { get; set; }
    string OU { get; set; }
    bool Silent { get; set; }
    bool MainWindowIsOpen { get; set; }
    string Domain { get; set; }
    string AboutTitle { get; set; }
    string AboutText { get; set; }
    string Host { get; set; }
    string SignalHost { get; set; }
    string Port { get; set; }
    string ConnectionString { get; set; }
}