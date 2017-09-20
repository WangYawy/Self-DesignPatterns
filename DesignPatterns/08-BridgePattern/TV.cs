using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BridgePattern
{
    /// <summary>
    /// 电视机抽象类
    /// </summary>
    abstract public class TV
    {
        abstract public void On();
        abstract public void Off();
        abstract public void TuneChannel();
    }
    /// <summary>
    /// 长虹TV，重写基类的抽象方法，具体实现
    /// </summary>
    public class ChangHongTV : TV
    {
        public override void Off()
        {
            Console.WriteLine("长虹TV已经关掉...");
        }

        public override void On()
        {
            Console.WriteLine("长虹TV已经打开...");
        }

        public override void TuneChannel()
        {
            Console.WriteLine("长虹TV换频道...");
        }
    }

    /// <summary>
    /// 海尔TV
    /// </summary>
    public class HaierTV : TV
    {
        public override void Off()
        {
            Console.WriteLine("海尔TV已经关掉...");
        }

        public override void On()
        {
            Console.WriteLine("海尔TV已经打开...");
        }

        public override void TuneChannel()
        {
            Console.WriteLine("海尔TV换频道...");
        }
    }
}
