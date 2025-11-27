using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.Defaults;
using ModerationApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModerationApp.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        public double[] Values { get; set; } = { 3, 6, 5, 3, 5, 8, 6 };
        public string[] DaysOfWeek { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public PieData[] Data { get; set; } = [
            new("Warnings", 2),
            new("Kicks", 5),
            new("Bans", 1),
            new("Notations", 5),
            new("Commendations", 8)
        ];

        public List<RecentModeration> RecentModerationActions { get; set; }
        public DashboardViewModel()
        {
            RecentModerationActions = new List<RecentModeration>()
            {
                new RecentModeration { Offender="PlayerOne", Type="Ban", Reason="Cheating", Issuer="Admin123", Date="2025-11-25" },
                new RecentModeration { Offender="PlayerTwo", Type="Kick", Reason="Offensive Language", Issuer="ModMike", Date="2025-11-24" },
                new RecentModeration { Offender="PlayerThree", Type="Warning", Reason="Spamming Chat", Issuer="Admin123", Date="2025-11-23" },
                new RecentModeration { Offender="PlayerFour", Type="Ban", Reason="Exploiting", Issuer="ModAnna", Date="2025-11-22" },
                new RecentModeration { Offender="PlayerFive", Type="Warning", Reason="Griefing", Issuer="Admin123", Date="2025-11-21" },
                new RecentModeration { Offender="PlayerOne", Type="Notation", Reason="Cheating", Issuer="Admin123", Date="2025-11-25" },
                new RecentModeration { Offender="PlayerTwo", Type="Commendation", Reason="Offensive Language", Issuer="ModMike", Date="2025-11-24" },
                new RecentModeration { Offender="PlayerThree", Type="Mute", Reason="Spamming Chat", Issuer="Admin123", Date="2025-11-23" },
                new RecentModeration { Offender="PlayerFour", Type="Ban", Reason="Exploiting", Issuer="ModAnna", Date="2025-11-22" },
                new RecentModeration { Offender="PlayerFive", Type="Warning", Reason="Griefing", Issuer="Admin123", Date="2025-11-21" },
                new RecentModeration { Offender="PlayerOne", Type="Ban", Reason="Cheating", Issuer="Admin123", Date="2025-11-25" },
                new RecentModeration { Offender="PlayerTwo", Type="Kick", Reason="Offensive Language", Issuer="ModMike", Date="2025-11-24" },
                new RecentModeration { Offender="PlayerThree", Type="Warning", Reason="Spamming Chat", Issuer="Admin123", Date="2025-11-23" },
                new RecentModeration { Offender="PlayerFour", Type="Ban", Reason="Exploiting", Issuer="ModAnna", Date="2025-11-22" },
                new RecentModeration { Offender="PlayerFive", Type="Warning", Reason="Griefing", Issuer="Admin123", Date="2025-11-21" }
            };
        }

    }
}
