using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractFactoryPattern
{
    /// <summary>
    /// 鸭架产品抽象类
    /// </summary>
    abstract public class YaJia
    {
        abstract public void Print();
    }

    /// <summary>
    /// 武汉鸭架
    /// </summary>
    public class WuHanYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("武汉鸭嘉，依然是辣的不要不要的！");
        }
    }

    /// <summary>
    /// 上海鸭架
    /// </summary>
    public class ShangHaiYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭架，依然是让人不敢相信的甜！");
        }
    }
}
