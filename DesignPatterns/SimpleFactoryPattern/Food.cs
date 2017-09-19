using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 菜抽象类
    /// </summary>
    abstract public class Food
    {
        /// <summary>
        /// 输出点了什么菜
        /// </summary>
        abstract public void Print();
    }

    /// <summary>
    /// 西红柿炒鸡蛋
    /// </summary>
    public class xihongshishaojidan : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒鸡蛋！");
        }
    }
    /// <summary>
    /// 土豆肉丝
    /// </summary>
    public class tudourousi : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }

}
