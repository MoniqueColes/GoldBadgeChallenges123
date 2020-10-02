using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    class ClaimMethods
    {
        //new content
        protected readonly List<ClaimProperties> _contentRepo = new List<ClaimProperties>();
        //add new content
        public bool AddContentToRepo(ClaimProperties content)
        {
            int startingCount = _contentRepo.Count;
            _contentRepo.Add(content);
            bool wasAdded = (_contentRepo.Count > startingCount) ? true : false;
            return wasAdded;
        }


        //show content
        public List<ClaimProperties> GetContents()
        {
            return _contentRepo;
        }

        public ClaimProperties GetContentByName(string name)
        {
            foreach (ClaimProperties oneContent in _contentRepo)
            {
                if (oneContent.ClaimID == claimID)
                {
                    return oneContent;
                }
            }
            return null;
        }

        //update content
        public bool UpdateExistingContent(string originalClaimID, ClaimMethods newContent)
        {
            ClaimMethods oldContent = GetContentByClaimID(originalClaimID);

            if (oldContent != null)
            {
                
                oldContent.ClaimID = newContent.ClaimID;
                oldContent.ClaimType = newContent.ClaimType;
                oldContent.Description = newContent.Description;
                oldContent.ClaimAmount = newContent.ClaimAmount;
                oldContent.DateOfIncident = newContent.DateOfIncident;
                oldContent.DateOfClaim = newContent.DateOfClaim;
                oldContent.IsValid = newContent.IsValid;

                return true;
            }
            else
            {
                return false;
            }
        }
        //delete content 
        public bool DeleteExistingContent(ClaimProperties existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }


    }
}
