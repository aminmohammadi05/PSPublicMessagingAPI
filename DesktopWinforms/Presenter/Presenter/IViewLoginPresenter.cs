
using PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;
using PSPublicMessagingAPI.Desktop.Presenter.View;

namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter;

public interface IViewLoginPresenter : IPresenter<IViewLogin>
{
    //void RunCalibrationMainForm();
    //void RunLaboratoryMainForm();
    //void RunQCFinalMainForm();
    void RunQCMainForm();
    //void RunQCYellowCardMainForm();
    bool SignIn(string userName, string password);
}