using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BuilderPattern
{
    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        // 电脑组件集合
        private IList<string> parts = new List<string>();

        /// <summary>
        /// 把单个组件添加到电脑组件集合中
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("开始组装...");
            foreach (var part in parts)
            {
                Console.WriteLine("组件 {0} 已装好", part);
            }

            Console.WriteLine("组装完成.");
        }
    }
}
