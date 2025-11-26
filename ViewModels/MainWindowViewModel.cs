using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModerationApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private object currentPage;
    public DashboardViewModel DashboardPage { get; }

    public ICommand NavigateToDashboardCommand { get; }

    public MainWindowViewModel()
    {
        DashboardPage = new DashboardViewModel();
        CurrentPage = DashboardPage;
    }

   

    private void NavigateToDashboard()
    {
        if (DashboardPage == null) return;
        CurrentPage = DashboardPage;
    }
}
