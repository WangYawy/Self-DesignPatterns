using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //以生活中炒蔬菜为例来实现下模板方法模式。在现实生活中，做蔬菜的步骤都大致相同，
            //如果我们针对每种蔬菜类定义一个烧的方法，这样在每个类中都有很多相同的代码，为了解决这个问题，
            //我们一般的思路肯定是把相同的部分抽象出来到抽象类中去定义，具体子类来实现具体的不同部分，
            //这个思路也正式模板方法的实现精髓所在


            Vagetabel spinach = new Spinach();
            spinach.CookVegetabel();
            Console.WriteLine();
            Vagetabel cabbage= new ChineseCabbage();
            cabbage.CookVegetabel();
        }
    }
}
