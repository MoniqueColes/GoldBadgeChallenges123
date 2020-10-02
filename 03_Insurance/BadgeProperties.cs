using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Insurance
    public enum DoorAccessneedadictionary
{
    A1,
    A2,
    A3,
    A4,
    A5,
    A6,
    A7,
}
{
    class BadgeProperties
    {
        public int BadgeID { get; set; }
        public bool OtherDoor { get; set; }
        
        public BadgeProperties() { }

        public BadgeProperties(int badgeID, bool otherDoor)
        {
            BadgeID = badgeID;
            OtherDoor = otherDoor;
        }


    }
}
