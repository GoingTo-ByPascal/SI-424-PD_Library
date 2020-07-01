using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.Factory
{
    public abstract class TravelableFactory
    {
        public abstract Travelable CreateTravelable();
        public abstract void SetState(IState<Travelable> state);
    }
}
