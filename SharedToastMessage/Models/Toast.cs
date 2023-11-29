namespace PSPublicMessagingAPI.SharedToastMessage.Models;


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