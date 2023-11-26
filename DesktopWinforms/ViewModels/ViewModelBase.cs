namespace PSPublicMessagingAPI.Desktop.ViewModels;

public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModelBase;
public class ViewModelBase : ObservableObject
{

}