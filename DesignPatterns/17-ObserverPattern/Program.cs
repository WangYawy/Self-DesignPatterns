using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象，这个主题对象在状态发生变化时，
            //会通知所有观察者对象，使它们能够自动更新自己的行为。

            // 实例化被观察者和观察者
            TenxunGame game = new TenxunGame();
            Subscriber sub = new Subscriber("HelloWord");
            game.Subscriber = sub;
            game.Symbol = "Tenxun Game";
            game.Info = "Have a new game pubilshed...";

            game.Update();

            Console.WriteLine();

            TenXun tenxun = new TenXunGame("TenXun Game","Have a new game published...");
            tenxun.AddObserver(new Subscriber2("JianLing"));
            tenxun.AddObserver(new Subscriber2("CrossFire"));
            tenxun.Update();
        }
    }
}
