using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ObserverPattern
{
    // 订阅号抽象类
    public abstract class TenXun
    {
        private List<IObserver> observers = new List<IObserver>();
        public string Symbol { get; set; }
        public string Info { get; set; }
        public TenXun(string symbol,string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }

        //新增
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        //删除
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Update()
        {
            foreach (var ob in observers)
            {
                ob.ReceiveAndPrint(this);
            }
        }
    }
    // 具体订阅号类
    public class TenXunGame : TenXun
    {
        public TenXunGame(string symbol, string info) : base(symbol, info)
        {
        }
    }

    // 订阅者接口
    public interface IObserver
    {
        void ReceiveAndPrint(TenXun tenxun);
    }
    // 具体订阅者
    public class Subscriber2 : IObserver
    {
        public Subscriber2(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public void ReceiveAndPrint(TenXun tenxun)
        {
            Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, tenxun.Symbol, tenxun.Info);
        }
    }
}
