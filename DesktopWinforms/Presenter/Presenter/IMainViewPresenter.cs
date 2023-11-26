using PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;
using PSPublicMessagingAPI.Desktop.Presenter.View;

namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter;

public interface IMainViewPresenter : IPresenter<IMainView>
{
    void RunCreateNewNotification();
}