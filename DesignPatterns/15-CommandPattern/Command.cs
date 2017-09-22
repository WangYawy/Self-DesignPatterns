using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CommandPattern
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
    abstract public class Command
    {
        // 命令的执行者
        protected Receiver _reveiver;
        public Command(Receiver receiver)
        {
            this._reveiver = receiver;
        }

        /// <summary>
        /// 命令执行方法
        /// </summary>
        abstract public void Action();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        { }

        public override void Action()
        {
            //调用接收者方法
            _reveiver.Run();
        }
    }
}
