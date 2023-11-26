using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.ViewModels;

namespace PSPublicMessagingAPI.Desktop.Services;

public class ToastService : ObservableObject, IToastService
{
    private Toast _toastMessage;
    public Toast ToastMessage
    {
        get
        {
            return _toastMessage;
        }
        set
        {
            _toastMessage = value;
            OnPropertyChanged(nameof(ToastMessage));
        }
    }



}