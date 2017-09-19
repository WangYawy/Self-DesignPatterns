using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractFactoryPattern
{
    /// <summary>
    /// 鸭脖产品抽象类
    /// </summary>
    abstract public class YaBo
    {
       abstract public void Print();
    }

    /// <summary>
    /// 武汉鸭脖，相同的产品位置不同，味道不一样制作方式不一样。
    /// </summary>
    public class WuHanYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("武汉鸭脖特别辣！");
        }
    }
    /// <summary>
    /// 上海鸭脖
    /// </summary>
    public class ShangHaiYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭脖甜的你信不信！");
        }
    }

}
