



using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Services;

namespace PSPublicMessagingAPI.Desktop.Presenter.View;

public interface IMainView : IView<IMainViewPresenter>
{
    IToastService ToastService { get; set; }

}