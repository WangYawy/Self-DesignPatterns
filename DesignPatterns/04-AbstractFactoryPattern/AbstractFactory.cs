using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AbstractFactoryPattern
{
    /// <summary>
    /// 抽象工厂，提供创建不同地方的鸭脖和鸭架的方法
    /// </summary>
    abstract public class AbstractFactory
    {
        // 会有一系列的产品，这里只放两个作为例子
        abstract public YaBo CreateYaBo();
        abstract public YaJia CreateYaJia();
    }

    /// <summary>
    /// 武汉出品
    /// </summary>
    public class WuHanFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new WuHanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new WuHanYaJia();
        }
    }
    /// <summary>
    /// 上海出品
    /// </summary>
    public class ShangHaiFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new ShangHaiYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new ShangHaiYaJia();
        }
    }
}
