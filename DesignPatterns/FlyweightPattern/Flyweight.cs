using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 抽象亨元类，提供具体亨元具有的方法
    /// </summary>
    abstract public class Flyweight
    {
        abstract public void Operation(int extrinsicstate);
    }

    /// <summary>
    /// 具体亨元对象，这样我们不把每个字母设计成一个单独的类了，而是作为把共享的字母作为亨元对象的内部状态
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        // 内部状态
        private string intrinsicstate;

        public ConcreteFlyweight(string innerState)
        {
            this.intrinsicstate = innerState;
        }
        /// <summary>
        /// 实例方法
        /// </summary>
        /// <param name="extrinsicstate">外部状态</param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体实现类：intrinsicstate {0} , extrinsicstate {1} ", intrinsicstate, extrinsicstate);
        }
    }
}
