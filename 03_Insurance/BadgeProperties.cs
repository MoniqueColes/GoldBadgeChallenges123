using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Insurance
{
    class BadgeProperties
    {
        public int BadgeID { get; set; }
        public string DoorNames { get; set; }

        public BadgeProperties() { }

        public BadgeProperties(int badgeID, string doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }

    }
}
