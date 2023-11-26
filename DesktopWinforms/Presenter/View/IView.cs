namespace PSPublicMessagingAPI.Desktop.Presenter.View;

public interface IView<TPresenter>
{
    TPresenter Presenter { get; set; }
    void Run();
}