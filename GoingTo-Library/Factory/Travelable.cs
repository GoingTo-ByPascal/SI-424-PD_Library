using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library.Factory
{
    public abstract class Travelable
    {
        public abstract string StateName { get; set; }
        public abstract IState<Travelable> CurrentState { get; set; }
        
    }
}
