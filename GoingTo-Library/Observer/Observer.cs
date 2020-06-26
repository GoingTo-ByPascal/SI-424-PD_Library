using System;
namespace GoingTo_Library.Observer
{
    public interface IObserver
    {
        void Update(object Target);
        void StartListening(IObservable Server);
        void StopListening();
    }
}
