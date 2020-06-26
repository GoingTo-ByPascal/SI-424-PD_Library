using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.State
{
    public class PastTripState : IState<Trip>
    {
        public void Future(Trip trip)
        {
            trip.Future();
        }

        public void Past(Trip trip)
        {
            throw new Exception("The trip is already in the past");
        }
    }
}
