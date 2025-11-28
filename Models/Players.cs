using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerationApp.Models
{
    public class Players
    {
        public ulong playerID { get; set; }
        public string username { get; set; }
        public string profileImage { get; set; }
        public string steamLink { get; set; }
        public int playTime { get; set; }
        public int trustscore { get; set; }
        public DateTime firstPlayed { get; set; }
        public DateTime lastPlayed { get; set; }
        public List<string> PermissionGroups { get; set; }
    }
}
