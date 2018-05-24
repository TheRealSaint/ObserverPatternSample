using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class DoSomeShit
    {
        public void DoSomething(ConcreteSubject cs)
        {
            Console.WriteLine("Enter new Observer Update Message");
            string newNews = Console.ReadLine();
            cs.setState(newNews);
            Console.ReadLine();
        }
    }
}
