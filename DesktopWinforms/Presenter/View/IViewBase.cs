
using System.DirectoryServices.ActiveDirectory;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;

namespace PSPublicMessagingAPI.Desktop.Presenter.View;

public interface IViewBase : IView<IViewBasePresenter>
{
    void ShowMessage(string message, ToastType toastType);
}