using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ObserverPattern
{
    /// <summary>
    /// 游戏订阅号类，即被观察者
    /// </summary>
    public class TenxunGame
    {
        public Subscriber Subscriber { get; set; }
        public string Symbol { get; set; }
        public string Info { get; set; }

        public void Update()
        {
            if (Subscriber != null)
            {
                Subscriber.ReceiveAndPrintData(this);
            }
        }
    }


    /// <summary>
    /// 订阅者,观察者
    /// </summary>
    public class Subscriber
    {
        public Subscriber(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public void ReceiveAndPrintData(TenxunGame txGame)
        {
            Console.WriteLine("Notified {0} Of {1}'s Info is {2} ", Name, txGame, txGame.Info);
        }
    }

}


