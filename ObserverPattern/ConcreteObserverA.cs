using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ConcreteObserverA : IObserver
    {
        public void Update(string news)
        {
            Console.WriteLine("Hi, I am Observer A:" );
            Console.WriteLine();
            Console.WriteLine("Check this News: " + news);            
        }
    }
}
