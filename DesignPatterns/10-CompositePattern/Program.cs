using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //组合模式允许你将对象组合成树形结构来表现”部分 - 整体“的层次结构，使得客户以一致的方式处理单个对象以及对象的组合。
            //下面我们用绘制的例子来详细介绍组合模式，图形可以由一些基本图形元素组成（如直线，圆等），
            //也可以由一些复杂图形组成（由基本图形元素组合而成），为了使客户对基本图形和复杂图形的调用保持一致，
            //我们使用组合模式来达到整个目的。
            //组合模式实现的最关键的地方是——简单对象和复合对象必须实现相同的接口。这就是组合模式能够将组合对象和简单对象进行一致处理的原因。

            Graphics g_line = new Line("线1");
            Graphics g_circle = new Circle("圆1");
            g_line.Draw();
            g_circle.Draw();

            
            // 复杂图形
            ComplexGraphics g = new ComplexGraphics("复杂图形");
            g.Add(g_line);
            g.Add(g_circle);
            g.Add(g_line);
            g.Add(new Circle("圆2"));
            Console.WriteLine("开始复杂tuxing...");
            g.Draw();
        }
    }
}
