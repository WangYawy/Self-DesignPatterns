using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractFactoryPattern
{
    /// <summary>
    /// 应对需求变更，比如新增了湖南分店，只需要创建湖南工厂，和对应产品即可
    /// </summary>
    public class HuNanFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new HuNanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new HuNanYaJia();
        }
    }

    public class HuNanYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("湖南鸭脖，也是有自己味道！");
        }

    }

    public class HuNanYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("湖南鸭架，不一样！");
        }
    }

}
