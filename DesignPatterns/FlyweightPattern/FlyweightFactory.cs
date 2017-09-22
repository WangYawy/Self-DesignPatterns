using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 亨元工厂，负责创建和管理亨元对象
    /// </summary>
    public class FlyweightFactory
    {
        public Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
            flyweights.Add("B", new ConcreteFlyweight("B"));
            flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            Flyweight flyweight = flyweights[key] as Flyweight;
            if (flyweight == null)
            {
                Console.WriteLine("不存在 {0}", key);
                flyweight = new ConcreteFlyweight(key);
            }
            return flyweight;
        }
    }
}
