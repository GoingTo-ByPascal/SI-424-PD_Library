using GoingTo_Library.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library
{
    public class Trip
    {
        private IState<Trip> CurrentState { get; set; }
        public Trip(IState<Trip> state)
        {
            CurrentState = state;
        }
        public Trip() : this(new FutureTripState()) { }

        public void SetState(IState<Trip> state)
        {
            CurrentState = state;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public List<Visit> Visits = new List<Visit>();

        public void Past()
        {
            CurrentState.Past(this);
        }
        public void Future()
        {
            CurrentState.Future(this);
        }

    }
}
