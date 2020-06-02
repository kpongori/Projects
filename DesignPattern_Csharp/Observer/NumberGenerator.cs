using System.Collections.Generic;

namespace Observer
{
    public abstract class NumberGenerator
    {
        private List<IObserver> observers = new List<IObserver> ();

        public void AddObserver (IObserver observer)
        {
            observers.Add (observer);
        }
        public void DeleteObserver (IObserver observer)
        {
            observers.Remove (observer);
        }
        public void NotifyObservers ()
        {
            foreach (var observer in observers)
            {
                observer.Update (this);
            }
        }
        public abstract int GetNumber ();
        public abstract void Execute ();
    }
}