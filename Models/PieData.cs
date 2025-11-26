using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerationApp.Models
{
    public class PieData(string name, double value)
    {
        public string Name { get; set; } = name;
        public double[] Values { get; set; } = [value];
    }
}
