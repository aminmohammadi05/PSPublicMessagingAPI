using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSPublicMessagingAPI.SharedToastMessage.Models;

namespace PSPublicMessagingAPI.SharedToastMessage.Services;
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
