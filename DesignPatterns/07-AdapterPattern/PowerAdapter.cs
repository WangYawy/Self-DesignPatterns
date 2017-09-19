using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AdapterPattern
{

    /// <summary>
    /// 三孔插头，也就是适配器模式中的目标角色
    /// </summary>
    public interface IThreeHole
    {
        void Request();
    }

    /// <summary>
    /// 两孔插头，源角色需要适配的类。
    /// </summary>
    public abstract class TwoHole
    {
        public void SpecificaRequest()
        {
            Console.WriteLine("我是两孔插头");
        }
    }
    /// <summary>
    /// 适配器类，提供了三孔插头的行为，但其本质是调用两孔插头的方法。实际中可根据两孔插头方法进行扩展
    /// </summary>
    public class PowerAdapter : TwoHole, IThreeHole
    {
        /// <summary>
        /// 实现三孔插头方法
        /// </summary>
        public void Request()
        {
            // 调用两孔插头方法
            this.SpecificaRequest();
        }
    }
}
