using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimRepository
    {
        //USE A QUEUE NOT A LIST
        Queue<ClaimContent> _claimsQueue = new Queue<ClaimContent>();

        public Queue<ClaimContent> GetClaims() 
        {
            return _claimsQueue ;
        }

        public void AddClaimsToQueue(ClaimContent content)
        {
            _claimsQueue.Enqueue(content);
        }

        public ClaimContent SeeContent()
        {
            return _claimsQueue.Peek();
        }
    }
}
