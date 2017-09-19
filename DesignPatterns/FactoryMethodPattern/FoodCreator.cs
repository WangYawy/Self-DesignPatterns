using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    abstract public class FoodCreator
    {
        // 工厂方法
        public abstract Food CreateFoodFactory();
    }
    /// <summary>
    /// 西红柿炒蛋工厂类
    /// </summary>
    public class xihongshichaojidanFactory : FoodCreator
    {
        public override Food CreateFoodFactory()
        {
            return new xihongshichaojidan();
        }
    }

    public class tudourousiFactory : FoodCreator
    {
        public override Food CreateFoodFactory()
        {
            return new tudourousi();
        }
    }

    // 我们我们还想多一个“肉沫茄子”，此时我们只需要定义一个肉末茄子具体工厂类和肉末茄子类就可以
    // 而不用像简单工厂模式中那样去修改工厂类中的实现（具体指添加case语句)。

    public class roumoqieziFacotry : FoodCreator
    {
        public override Food CreateFoodFactory()
        {
            return new roumoqiezi();
        }
    }
}
