using GoingTo_Library.State;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace GoingTo_Library
{
    public class Visit
    {
        public Visit(IState<Visit> state)
        {
            CurrentState = state;
        }
        public Visit() : this(new FutureVisitState()) { }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        private IState<Visit> CurrentState { get; set; }

        public Locatable Locatable { get; set; }
        public int LocatableId { get; set; }
        public Trip Trip { get; set; }
        public int TripId { get; set; }

        public void SetState(IState<Visit> state)
        {
            CurrentState = state;
        }

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
