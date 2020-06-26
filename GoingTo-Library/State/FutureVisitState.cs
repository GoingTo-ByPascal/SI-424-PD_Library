using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GoingTo_Library.State
{
    public class FutureVisitState : IState<Visit>
    {
        public void Future(Visit visit)
        {
            throw new Exception("The visit is already in future");
        }

        public void Past(Visit visit)
        {
            visit.Past();
        }
    }
}
