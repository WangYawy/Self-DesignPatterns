using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region // Customer1
            Console.WriteLine("自己做");
            // 自己做自己要的
            Food food1 = Customer1.Cook(FoodType.xihongsichaojidan);
            food1.Print();

            Food food2 = Customer1.Cook(FoodType.tudourousi);
            food2.Print();
            Console.WriteLine("自己做结束");
            #endregion
            //自己做饭，如果我们想吃别的菜时，此时就需要去买这种菜和洗菜这些繁琐的操作，
            //有了餐馆（也就是简单工厂）之后，我们就可以把这些操作交给餐馆去做，
            //此时消费者（也就是我们）对菜（也就是具体对象）的依赖关系从直接变成的间接的，
            //这样就是实现了面向对象的另一个原则——降低对象之间的耦合度，
            //下面就具体看看有了餐馆之后的实现代码（即简单工厂的实现）：
            #region // Customer2
            Console.WriteLine("客户点菜，厨师做");
            // 客户点菜
            Customer2 customer = new Customer2();
            customer.type = new FoodType[] { FoodType.tudourousi, FoodType.xihongsichaojidan };
            // 厨师做菜
            foreach (var item in customer.type)
            {
                Food food = FoodSimpleFactory.CreateFood(item);
                food.Print();
            }
            // 第二个客户点菜
            Customer2 customer2 = new Customer2();
            customer2.type = new FoodType[] { FoodType.tudourousi };
            // 做第二个客户的菜
            foreach (var item in customer2.type)
            {
                Food food = FoodSimpleFactory.CreateFood(item);
                food.Print();
            }
            Console.WriteLine("客户点菜，厨师做结束");
            #endregion


            Console.Read();
        }
    }
}
