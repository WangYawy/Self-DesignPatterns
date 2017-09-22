using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CommandPattern
{
    /// <summary>
    /// 负责调用传达请求
    /// </summary>
    public class Invoke
    {
        public Command _command;
        public Invoke(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Action();
        }
    }
}
