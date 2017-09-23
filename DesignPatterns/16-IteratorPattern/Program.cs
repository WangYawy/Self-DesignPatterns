using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 迭代器是针对集合对象而生的，对于集合对象而言，必然涉及到集合元素的添加删除操作，同时也肯定支持集合元素遍历的操作，
            // 我们此时可以把遍历操作也放在集合对象中，但这样的话，集合对象就承担太多责任，面向对象设计原则中有一条是单一职责原则，
            // 所以我们要尽可能的分离这些职责，用不同的类承担不同的职责。迭代器模式就是用迭代器类来承担遍历集合元素的职责。

            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i);
                iterator.Next();
            }
        }
    }
}
