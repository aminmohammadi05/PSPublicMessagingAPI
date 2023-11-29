

using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Domain.UserRoles;

namespace PSPublicMessagingAPI.Desktop.Services;

public class ActiveDirectoryService : IActiveDirectoryService
{
    private readonly ICommunicationApplicationController _applicationController;
    IConfigurationManagerService _configurationManagerService;
    private string currentUser;
    private string ou;

    public List<LDAPUser> ActiveDirectoryUsers { get; set; }
    public string CurrentUser
    {
        get => currentUser;
        set
        {
            currentUser = value;
        }
    }
    public string OU
    {
        get => ou;
        set
        {
            ou = value;
        }
    }

    public ActiveDirectoryService(IConfigurationManagerService configurationManagerService, ICommunicationApplicationController applicationController)
    {
        _applicationController = applicationController;
        _configurationManagerService = configurationManagerService;
        using (var context = new PrincipalContext(ContextType.Domain, _configurationManagerService.Domain))
        {
            using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
            {

                ActiveDirectoryUsers = searcher.FindAll().Select(result => new LDAPUser()
                {
                    AccountName = result.SamAccountName,
                    FullName = result.DisplayName,
                    OUName = result.DistinguishedName != null &&
                            result.DistinguishedName.Split(new char[] { ',' }).Any() &&
                            result.DistinguishedName.Split(new char[] { ',' }).Any(x => x.Trim().StartsWith("OU")) ?
                            result.DistinguishedName.Split(new char[] { ',' }).FirstOrDefault(x => x.Trim().StartsWith("OU")).Split(new char[] { '=' })[1] : String.Empty,
                    PrincipalName = result.UserPrincipalName,

                }).ToList();

            }
        }

    }

    public LDAPUser LoginToActiveDirectoryUser(string userName, string password)
    {
        PrincipalContext pc = new PrincipalContext(ContextType.Domain, _configurationManagerService.Domain);
        bool Valid = pc.ValidateCredentials(userName, password);
        if (!Valid)
        {

            return null;
        }

        _configurationManagerService.UserName = userName;
        _configurationManagerService.Password = password;
        _configurationManagerService.OU = ActiveDirectoryUsers.FirstOrDefault(x => x.AccountName == userName).OUName;
        CurrentUser = userName;
        OU = ActiveDirectoryUsers.FirstOrDefault(x => x.AccountName == userName).OUName;
        return ActiveDirectoryUsers.FirstOrDefault(x => x.AccountName == userName);
    }

    public LDAPUser GetActiveDirectoryUser(string userName)
    {
        return ActiveDirectoryUsers.FirstOrDefault(x => x.AccountName == userName);
    }
    public async Task<List<UserRole>> GetUserRoles(string userName)
    {
        return await _applicationController.GetUserRoleAsync(userName);
    }
}