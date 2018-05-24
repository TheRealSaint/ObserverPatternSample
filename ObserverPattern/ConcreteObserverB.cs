using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class ConcreteObserverB : Form, IObserver
    {
        public ConcreteObserverB()
        {
            InitializeComponent();            
        }

        public void Update(string news)
        {
            listBox1.Items.Add("Hi, I am Observer B: ");
            listBox1.Items.Add("Check out that news: " + news);
        }
    }
}
