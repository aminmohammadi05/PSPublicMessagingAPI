using PSPublicMessagingAPI.Desktop.Presenter.View;

namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter;

public class MainViewPresenter : IMainViewPresenter
{
    private readonly IMainView _view;
    private readonly ICommunicationApplicationController _communicationAppController;
    public MainViewPresenter(IMainView view, ICommunicationApplicationController communicationAppController)
    {
        _view = view;
        _communicationAppController = communicationAppController;
        _view.Presenter = this;
    }
    public IMainView View
    {
        get
        {
            return _view;
        }

    }





    public void Run()
    {
        _view.Run();
    }

    public void RunCreateNewNotification()
    {
        _communicationAppController.RunCreateNewNotification();
    }
}