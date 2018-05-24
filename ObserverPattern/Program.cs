using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject myConcreteSubject = new ConcreteSubject();

            ConcreteObserverA myConcreteObserverA = new ConcreteObserverA(); //Console
            ConcreteObserverB myConcreteObserverB = new ConcreteObserverB(); //Forms Fenster

            myConcreteSubject.addObserver(myConcreteObserverA);
            myConcreteSubject.addObserver(myConcreteObserverB);
            myConcreteSubject.setState("Hello World");

            Application.Run(myConcreteObserverB); //Forms Fenster
            DoSomeShit test = new DoSomeShit();
            test.DoSomething(myConcreteSubject);
        }

        
    }
}
