



using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.SharedToastMessage.Services;

namespace PSPublicMessagingAPI.Desktop.Presenter.View;

public interface IMainView : IView<IMainViewPresenter>
{
    IToastService ToastService { get; set; }

}