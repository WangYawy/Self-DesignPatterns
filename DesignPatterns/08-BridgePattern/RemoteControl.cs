using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BridgePattern
{
    /// <summary>
    /// 抽象概念中的遥控器,即一个遥控器应该是什么样的，具有什么属性，实现哪些方法？
    /// </summary>
    public class RemoteControl
    {
        private TV implementor; // 实现者，遥控器控制的是TV，TV具体实现需要的操作

        public TV Implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }

        /// <summary>
        /// 不具体实现，调用实现类TV中的方法
        /// </summary>
        public virtual void On()
        {
            implementor.On();
        }
        public virtual void Off()
        {
            implementor.Off();
        }
        public virtual void SetChannel()
        {
            implementor.TuneChannel();
        }
    }

    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("发出指令：SetChannel");
            base.SetChannel();
            Console.WriteLine("完成指令：SetChannel");
        }
    }
}
