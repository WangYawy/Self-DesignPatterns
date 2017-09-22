using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CompositePattern
{
    /// <summary>
    /// 图形抽象类
    /// </summary>
    abstract public class Graphics
    {
        public string Name { get; set; }
        public Graphics(string name)
        {
            this.Name = name;
        }

        abstract public void Draw();
        //abstract public void Add(Graphics g);
        //abstract public void Remove(Graphics g);
    }

    /// <summary>
    /// 简单图形-线
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine("画{0}", this.Name);
        }

        // 因为简单图形在添加或移除其他图形，所以简单图形Add或Remove方法没有任何意义
        // 如果客户端调用了简单图形的Add或Remove方法将会在运行时抛出异常
        // 我们可以在客户端捕获该类移除并处理
        //public override void Add(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Line添加其他图形");
        //}
        //public override void Remove(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Line移除其他图形");
        //}
    }

    /// <summary>
    /// 简单图形-圆
    /// </summary>
    public class Circle : Graphics
    {
        public Circle(string name) : base(name)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("画{0}", this.Name);
        }
        // 因为简单图形在添加或移除其他图形，所以简单图形Add或Remove方法没有任何意义
        // 如果客户端调用了简单图形的Add或Remove方法将会在运行时抛出异常
        // 我们可以在客户端捕获该类移除并处理
        //public override void Add(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Circle添加其他图形");
        //}
        //public override void Remove(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Circle移除其他图形");
        //}
    }

    public class ComplexGraphics : Graphics
    {
        List<Graphics> list = new List<Graphics>();
        public ComplexGraphics(string name) : base(name)
        {
        }

        public void Add(Graphics g)
        {
            list.Add(g);
        }

        public override void Draw()
        {
            foreach (var item in list)
            {
                item.Draw();
            }
        }

        public void Remove(Graphics g)
        {
            list.Remove(g);
        }
    }

}
