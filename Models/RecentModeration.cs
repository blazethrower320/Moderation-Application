using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerationApp.Models
{
    public class RecentModeration
    {
        public string Offender { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Issuer { get; set; }
        public string Date { get; set; }
    }
}
