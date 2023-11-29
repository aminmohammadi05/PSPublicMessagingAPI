using PSPublicMessagingAPI.SharedToastMessage.Models;

namespace PSPublicMessagingAPI.SharedToastMessage.Services;

public interface IToastService
{
    Toast ToastMessage { get; set; }

}