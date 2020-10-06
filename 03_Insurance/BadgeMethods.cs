using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InsuranceBadge
{
    public class BadgeMethods

    {
        private Dictionary<int, List<string>> _doorList = new Dictionary<int, List<string>>();

        // C create new badge
        public void AddNewBadge(int badgeID, List<string> doors)
        {
            _doorList.Add(badgeID, doors);
        }

        // R show all badges
        public Dictionary<int, List<string>> ListAllBadges()
        {
            return _doorList;
        }

        // U update badges
        public void UpdateBadge(int badgeID, string door)
        {
            foreach (int id in _doorList.Keys)
            {
                if (badgeID == id)
                {
                    _doorList[id].Add(door);
                }
            }
        }

        // D delete badge
        public void DeleteBadge(int badgeID)
        {
            _doorList.Remove(badgeID);

        }
    }
}
