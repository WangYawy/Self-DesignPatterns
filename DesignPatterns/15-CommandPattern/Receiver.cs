using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CommandPattern
{
    /// <summary>
    /// 命令接受者即最终执行者
    /// </summary>
    public class Receiver
    {
        public void Run()
        {
            Console.WriteLine("跑1000米");
        }
    }
}
