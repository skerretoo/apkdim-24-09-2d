using CommunityToolkit.Mvvm.ComponentModel;

namespace budujemyoknorecznie.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string greeting = "Welcome to Avalonia!";
}
