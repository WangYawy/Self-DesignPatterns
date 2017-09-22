using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TemplateMethodPattern
{
    /// <summary>
    /// 抽象类
    /// </summary>
    abstract public class Vagetabel
    {
        // 模板方法，不要把模版方法定义为Virtual或abstract方法，避免被子类重写，防止更改流程的执行顺序
        public void CookVegetabel()
        {
            Console.WriteLine("炒蔬菜的一般步骤");
            this.pourOil();
            this.HeatOil();
            this.pourVegetabel();
            this.stir_fry();
        }

        public void pourOil()
        {
            Console.WriteLine("倒油");
        }

        public void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }
        /// <summary>
        /// 油热之后放菜进去，具体放什么菜，由具体实现决定
        /// </summary>
        public abstract void pourVegetabel();

        public void stir_fry()
        {
            Console.WriteLine("翻炒");
        }
    }

    public class Spinach : Vagetabel
    {
        public override void pourVegetabel()
        {
            Console.WriteLine("把菠菜倒进去");
        }
    }

    public class ChineseCabbage : Vagetabel
    {
        public override void pourVegetabel()
        {
            Console.WriteLine("把大白菜倒进去");
        }
    }
}
