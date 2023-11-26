
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;

namespace PSPublicMessagingAPI.Desktop.Presenter.View;

public interface IViewLogin : IView<IViewLoginPresenter>
{
    //List<UserAction> UserAction { get; set; }
    void HideLoginForm(bool state);
}