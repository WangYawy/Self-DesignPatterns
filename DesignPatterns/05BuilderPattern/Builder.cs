using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BuilderPattern
{
    /// <summary>
    /// 抽象建造者，组装人，也可以定义为接口
    /// </summary>
    abstract public class Builder
    {
        /// <summary>
        /// 装CPU
        /// </summary>
        abstract public void BuildPartCPU();
        /// <summary>
        /// 装主板
        /// </summary>
        abstract public void BuildPartMainBoard();
        // 还可以做别的事，装硬盘，电源等的

        abstract public Computer GetComputer();
    }

    /// <summary>
    /// 具体创建者， 组装人1
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU1");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("Main Board1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }

    public class ConcreteBuilder2 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU2");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("Main Board2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
