using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InsuranceBadge
{
    public class BadgeProperties
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }

        public BadgeProperties() { }

        public BadgeProperties(int badgeID, List<string> doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }

    }
}
