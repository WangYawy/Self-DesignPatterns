using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 菜抽象类
    /// </summary>
    abstract public class Food
    {
        // 输出是什么菜
        public abstract void Print();
    }

    /// <summary>
    /// 西红柿炒鸡蛋
    /// </summary>
    public class xihongshichaojidan : Food
    {
        public override void Print()
        {
            Console.WriteLine("我是西红柿炒鸡蛋！");
        }
    }
    /// <summary>
    /// 土豆肉丝
    /// </summary>
    public class tudourousi : Food
    {
        public override void Print()
        {
            Console.WriteLine("我是土豆肉丝"); 
        }
    }

    // 我们我们还想多一个“肉沫茄子”，此时我们只需要定义一个肉末茄子具体工厂类和肉末茄子类就可以
    // 而不用像简单工厂模式中那样去修改工厂类中的实现（具体指添加case语句)。
    public class roumoqiezi : Food
    {
        public override void Print()
        {
            Console.WriteLine("我是肉沫茄子");
        }
    }

}
