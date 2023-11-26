using PSPublicMessagingAPI.Desktop.ViewModels;

namespace PSPublicMessagingAPI.Desktop.Models;

public enum ToastType
{
    Success,
    Error,
    Info,
    Warning
}
public class Toast : ObservableObject
{
    private ToastType _toastType;
    private string _message;
    public ToastType ToastType
    {
        get
        {
            return _toastType;
        }
        set
        {
            _toastType = value;
            OnPropertyChanged(nameof(ToastType));
        }
    }
    public string Message
    {
        get
        {
            return _message;
        }
        set
        {
            _message = value;
            OnPropertyChanged(nameof(Message));
        }
    }
}