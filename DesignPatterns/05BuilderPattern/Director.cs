using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BuilderPattern
{
    /// <summary>
    /// 指挥创建过程类，喊别人去组装电脑
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartMainBoard();
        }
    }
}
