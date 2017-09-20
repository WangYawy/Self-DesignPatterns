using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //以电视遥控器的一个例子来引出桥接模式解决的问题
            // 桥接模式即将抽象部分与实现部分脱耦，使它们可以独立变化。

            RemoteControl control = new ConcreteRemote();

            // 被遥控TV
            control.Implementor = new ChangHongTV();
            control.On();
            control.SetChannel();
            control.Off();
            Console.WriteLine();

            control.Implementor = new HaierTV();
            control.On();
            control.SetChannel();
            control.Off();
            Console.WriteLine();


            // 三层架构就是使用的桥接模式

            BussinessObject bussiness = new BussinessObject("BeiJing");
            bussiness.Dataacces = new CustomerDataAccess();

            bussiness.Add("小六");
            Console.WriteLine("添加 小六");
            bussiness.Add("小五");
            Console.WriteLine("添加 小五");
            bussiness.Show();
            bussiness.Update(1,"小四");
            Console.WriteLine("更改小五为小四");
            bussiness.Show();
            bussiness.Delete("小六");
            Console.WriteLine("删除 小六");
            bussiness.Show();
        }
    }
}
