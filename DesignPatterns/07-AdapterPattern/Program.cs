using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 现在我们买的电器插头是2个孔，但是我们买的插座只有3个孔的
            // 我们想把电器插在插座上的话就需要一个电适配器，让三孔的同时具备两孔的功能。
            IThreeHole threehole = new PowerAdapter();
            threehole.Request();
            Console.Read();

            ThreeHole_Object three = new ThreeHole_Object();
            three.Request();
            ThreeHole_Object adapter = new ObjectAdapter();
            adapter.Request();
            Console.Read();
        }
    }
}
