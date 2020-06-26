using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.State
{
    public class FutureTripState : IState<Trip>
    {
        public void Future(Trip trip)
        {
            throw new Exception("The trip is already in the future");
        }

        public void Past(Trip trip)
        {
            trip.Past();
        }
    }
}
