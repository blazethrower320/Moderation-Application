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
    public PlayersViewModel PlayersPage { get; }

    public ICommand NavigateToDashboardCommand { get; }
    public ICommand NavigateToPlayersPageCommand { get; }

    public MainWindowViewModel()
    {
        DashboardPage = new DashboardViewModel();
        PlayersPage = new PlayersViewModel();

        NavigateToDashboardCommand = new RelayCommand(NavigateToDashboard);
        NavigateToPlayersPageCommand = new RelayCommand(NavigateToPlayers);

        CurrentPage = DashboardPage;
    }



    private void NavigateToDashboard()
    {
        if (DashboardPage == null) return;
        CurrentPage = DashboardPage;
    }
    private void NavigateToPlayers()
    {
        if (DashboardPage == null) return;
        CurrentPage = PlayersPage;
    }
}
