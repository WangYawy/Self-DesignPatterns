using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DecoratorPattern
{
    /// <summary>
    /// 手机抽象类，即装饰者模式的抽象组件类
    /// </summary>
    abstract public class Phone
    {
        public string Name { get; set; }
        public abstract void Print();
    }

    /// <summary>
    /// 手机实体，即装饰者模式的具体组件类
    /// </summary>
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体的对象-{0}手机", this.Name);
        }
    }


}
