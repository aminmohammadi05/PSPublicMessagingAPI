

using System.Collections.Generic;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Domain.UserRoles;

namespace PSPublicMessagingAPI.Desktop.Services;

public interface IActiveDirectoryService
{
    string CurrentUser { get; set; }
    string OU { get; set; }
    List<LDAPUser> ActiveDirectoryUsers { get; set; }
    LDAPUser GetActiveDirectoryUser(string userName);
    LDAPUser LoginToActiveDirectoryUser(string userName, string password);
    Task<UserRole> GetUserRoles(string userName);
}