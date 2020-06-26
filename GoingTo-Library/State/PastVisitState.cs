using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.State
{
    public class PastVisitState : IState<Visit>
    {
        public void Future(Visit visit)
        {
            visit.Future();
        }

        public void Past(Visit visit)
        {
            throw new Exception("The visit is already in past");
        }
    }
}
