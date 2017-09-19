using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化做菜工厂
            FoodCreator xihongshichaojidanFactory = new xihongshichaojidanFactory();
            FoodCreator tudourousiFactory = new tudourousiFactory();

            // 开始做
            Food xihongshichaojidan = xihongshichaojidanFactory.CreateFoodFactory();
            xihongshichaojidan.Print();

            Food tudourousi = tudourousiFactory.CreateFoodFactory();
            tudourousi.Print();

            // 再加一个肉沫茄子
            FoodCreator roumoqieziFactory = new roumoqieziFacotry();

            Food roumoqiezi = roumoqieziFactory.CreateFoodFactory();
            roumoqiezi.Print();
        }
    }
}
