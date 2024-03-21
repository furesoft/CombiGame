using Avalonia.Controls;
using CombiGame.ViewModels;

namespace CombiGame.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        this.DataContext = new MainViewModel();
    }
}