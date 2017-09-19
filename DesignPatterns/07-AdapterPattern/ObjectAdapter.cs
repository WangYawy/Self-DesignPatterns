using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AdapterPattern
{

    public class ThreeHole_Object
    {
        public virtual void Request()
        {
            Console.WriteLine("三孔插头一般使用方法");
        }
    }

    public class TwoHole_Object
    {
        public void SpecificRequest()
        {
            Console.WriteLine("两孔插头的一般使用方法");
        }
    }

    /// <summary>
    /// 对象适配器
    /// </summary>
    public class ObjectAdapter : ThreeHole_Object
    {
        public TwoHole_Object twoAdapter = new TwoHole_Object();
        public override void Request()
        {
            // base.Request();
            twoAdapter.SpecificRequest();
        }
    }
}
