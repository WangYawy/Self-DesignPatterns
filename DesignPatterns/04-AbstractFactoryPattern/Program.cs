using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 抽象工厂模式：提供一个创建产品的接口来负责创建相关或依赖的对象，而不具体明确指定具体类

            // 例如，绝味鸭脖想在武汉和上海开分店，但是由于当地人的口味不一样，在武汉的所有绝味的东西会做的辣一点，
            // 而上海不喜欢吃辣的，所以上海的所有绝味的东西都不会做的像武汉的那样辣，
            // 然而这点不同导致武汉绝味工厂和上海的绝味工厂生成所有绝味的产品都不同，
            // 也就是某个具体工厂需要负责一系列产品(指的是绝味所有食物)的创建工作，

            // 武汉生产的鸭脖鸭架
            AbstractFactory wuHanFactory = new WuHanFactory();
            YaBo wuHanYaBo = wuHanFactory.CreateYaBo();
            wuHanYaBo.Print();
            YaJia wuHanYaJia = wuHanFactory.CreateYaJia();
            wuHanYaJia.Print();
            // 上海生产的鸭脖鸭架
            AbstractFactory shangHaiFactory = new ShangHaiFactory();
            shangHaiFactory.CreateYaBo().Print();
            shangHaiFactory.CreateYaJia().Print();

            // 新增湖南
            AbstractFactory huNanFactory = new HuNanFactory();
            huNanFactory.CreateYaBo().Print();
            huNanFactory.CreateYaJia().Print();

        }
    }
}
