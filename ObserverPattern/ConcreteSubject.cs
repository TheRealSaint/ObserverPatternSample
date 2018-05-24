using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private string news;

        public void setState(string news)
        {
            this.news = news;
            notifyObserver(news);
        }

        public string getState()
        {
            return news;
        }

    }
}
