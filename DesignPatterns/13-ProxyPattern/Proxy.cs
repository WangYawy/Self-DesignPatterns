using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ProxyPattern
{

    /// <summary>
    /// 抽象主题角色
    /// </summary>
    abstract public class Person
    {
        abstract public void BuyProduct();
    }

    /// <summary>
    /// 真是主题角色
    /// </summary>
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("买个手机买个电脑");
        }
    }
    /// <summary>
    /// 代理角色
    /// </summary>
    public class Friend : Person
    {
        /// <summary>
        /// 真是主题实例
        /// </summary>
        RealBuyPerson real;
        public override void BuyProduct()
        {
            Console.WriteLine("通过代理访问真是实体对象方法");
            if (real == null)
            {
                real = new RealBuyPerson();
            }
            this.PreBuy();
            real.BuyProduct();
            this.PostBuy();
        }


        // 代理角色执行的操作
        public void PreBuy()
        {
            // 东西较多 列个清单
            Console.WriteLine("张三手机，李四电脑");
        }

        public void PostBuy()
        {
            Console.WriteLine("买完之后分类，手机是张三的，电脑是李四的");
        }
    }
}
