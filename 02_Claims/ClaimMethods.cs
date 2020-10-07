using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class ClaimMethods
    {
        //new content
        protected readonly List<ClaimProperties> _contentRepo = new List<ClaimProperties>();
        //create queue
        Queue<int> claimQueue = new Queue<int>();
        //add new content
        public bool AddContentToRepo(ClaimProperties content)
        {
            int startingCount = _contentRepo.Count;
            _contentRepo.Add(content);
            bool wasAdded = (_contentRepo.Count > startingCount) ? true : false;

            claimQueue.Enqueue(content.ClaimID);
            return wasAdded;
        }

        //pull next content from queue
        public int ClaimQueueUp()
        {
            return claimQueue.Peek();
        }

        //show content
        public List<ClaimProperties> GetClaims()
        {
           return _contentRepo;
        }

        //dequeue
        public void ClaimDequeue()
        {
            int firstClaim = claimQueue.Dequeue();
        }
    }
}
