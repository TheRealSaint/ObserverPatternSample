using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        private List<IObserver> observerListe = new List<IObserver>();

        public void addObserver(IObserver newObserverObjekt)
        {
            observerListe.Add(newObserverObjekt);
            Console.WriteLine("Observer >>> " + newObserverObjekt.ToString() + " <<< der Liste der Beobachter hinzugefuegt!");
        }

        public void removeObserver(IObserver newObserverObjekt)
        {
            observerListe.Remove(newObserverObjekt);
            Console.WriteLine("Observer >>> " + newObserverObjekt.ToString() + " <<< aus der Liste der Beobachter entfernt!");
        }

        public void notifyObserver(string news)
        {
            foreach (IObserver observer in observerListe)
            {
                observer.Update(news);
            }
        }
    }
}
