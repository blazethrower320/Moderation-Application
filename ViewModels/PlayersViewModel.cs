using CommunityToolkit.Mvvm.ComponentModel;
using ModerationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerationApp.ViewModels
{
    public partial class PlayersViewModel : ObservableObject
    {
        public List<Players> PlayerList { get; set; }
        public PlayersViewModel() 
        {
            PlayerList = new List<Players>()
            {
                new Players { playerID = 76561198012345678, username = "NovaKnight", profileImage = "https://avatars.fastly.steamstatic.com/ee8fe69a429c67e6226b38ce886271de6538b95f.jpg", steamLink = "https://steamcommunity.com/profiles/76561198012345678", playTime = 4820, trustscore = 87, firstPlayed = new DateTime(2022, 5, 12), lastPlayed = DateTime.Now.AddHours(-3), PermissionGroups = new List<string>{"Default" } },
                new Players { playerID = 76561198087654321, username = "ShadowReaper", profileImage = "https://avatars.fastly.steamstatic.com/ee8fe69a429c67e6226b38ce886271de6538b95f.jpg", steamLink = "https://steamcommunity.com/profiles/76561198087654321", playTime = 1640, trustscore = 62, firstPlayed = new DateTime(2023, 1, 3), lastPlayed = DateTime.Now.AddDays(-1), PermissionGroups = new List<string>{"Default" }},
                new Players { playerID = 76561198123456789, username = "PixelPenguin", profileImage = "https://avatars.fastly.steamstatic.com/ee8fe69a429c67e6226b38ce886271de6538b95f.jpg", steamLink = "https://steamcommunity.com/profiles/76561198123456789", playTime = 256, trustscore = 94, firstPlayed = new DateTime(2024, 3, 21), lastPlayed = DateTime.Now.AddMinutes(-45), PermissionGroups = new List<string>{"Default" }},
                new Players { playerID = 76561198987654321, username = "RogueZero", profileImage = "https://avatars.fastly.steamstatic.com/ee8fe69a429c67e6226b38ce886271de6538b95f.jpg", steamLink = "https://steamcommunity.com/profiles/76561198987654321", playTime = 7850, trustscore = 41, firstPlayed = new DateTime(2021, 11, 14), lastPlayed = DateTime.Now.AddHours(-12),PermissionGroups = new List<string>{"Default" }},
                new Players { playerID = 76561198234567890, username = "CrimsonViper", profileImage = "https://avatars.fastly.steamstatic.com/ee8fe69a429c67e6226b38ce886271de6538b95f.jpg", steamLink = "https://steamcommunity.com/profiles/76561198234567890", playTime = 1120, trustscore = 74, firstPlayed = new DateTime(2023, 8, 8), lastPlayed = DateTime.Now.AddDays(-7), PermissionGroups = new List<string>{"Default" } },
            };
        }
    }
}
