namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;

public interface IPresenter<TView>
{
    TView View { get; }
    void Run();
}