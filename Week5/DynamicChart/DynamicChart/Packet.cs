using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicChart
{
    internal class Packet
    {

        public int Id { get; set; }
        public double Time { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Protocol { get; set; }
        public int Length { get; set; }
        public string Info { get; set; }
    }
}
