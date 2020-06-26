using System;
using System.Collections.Generic;
using System.Text;

namespace GoingTo_Library
{
    public interface IState<T>
    {
        void Past(T trip);
        void Future(T trip);
    }
}
