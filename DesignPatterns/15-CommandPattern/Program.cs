using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //军训的例子来实现一个命令模式，在实现之前，可以参考下命令模式的结构图来分析下实现过程。
            //军训场景中，具体的命令即是学生跑1000米，这里学生是命令的接收者，教官是命令的请求者，院领导是命令的发出者，即客户端角色。
            //要实现命令模式，则必须需要一个抽象命令角色来声明约定，这里以抽象类来来表示。命令的传达流程是：
            //命令的发出者必须知道具体的命令、接受者和传达命令的请求者，对应于程序也就是在客户端角色中需要实例化三个角色的实例对象了。
            //命令的请求者负责调用命令对象的方法来保证命令的执行，对应于程序也就是请求者对象需要有命令对象的成员，
            //并在请求者对象的方法内执行命令。
            //具体命令就是跑1000米，这自然属于学生的责任，所以是具体命令角色的成员方法，而抽象命令类定义这个命令的抽象接口。

            Receiver _receiver = new Receiver();
            Command _command = new ConcreteCommand(_receiver);
            Invoke _invoke = new Invoke(_command);
            _invoke.ExecuteCommand();
        }
    }
}
