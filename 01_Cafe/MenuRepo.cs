using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
     public class MenuRepo
    {
        //Create
        protected readonly List<MenuContent> _contentRepo = new List<MenuContent>();
        //Create
        public bool AddContentToRepo(MenuContent content)
        {
            int startingCount = _contentRepo.Count;
            _contentRepo.Add(content);
            bool wasAdded = (_contentRepo.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<MenuContent> GetContents()
        {
            return _contentRepo;
        }

        public MenuContent GetContentByName(string name)
        {
            foreach (MenuContent oneContent in _contentRepo)
            {
                if (oneContent.Name.ToLower() == name.ToLower())
                {
                    return oneContent;
                }
            }
            return null;
        }

        //Delete
        public bool DeleteExistingContent(MenuContent existingContent)
        {
            bool deleteResult = _contentRepo.Remove(existingContent);
            return deleteResult;
        }
     }
}
