using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //这个例子是：一个文本编辑器中会出现很多字面，使用享元模式去实现这个文本编辑器的话，会把每个字面做成一个享元对象。
            //享元对象的内部状态就是这个字面，而字母在文本中的位置和字体风格等其他信息就是它的外部状态。
            //内部状态：在享元对象的内部并且不会随着环境的改变而改变的共享部分
            //外部状态：随环境改变而改变的，不可以共享的状态。

            // 定义外部状态
            int externalstate = 10;
            // 初始化工厂
            FlyweightFactory factory = new FlyweightFactory();
            //判断A
            Flyweight fa = factory.GetFlyweight("A");
            fa.Operation(--externalstate);
            //判断B
            Flyweight fb = factory.GetFlyweight("B");
            fb.Operation(--externalstate);
            //判断C
            Flyweight fc = factory.GetFlyweight("C");
            fc.Operation(--externalstate);
            //判断D
            Flyweight fd = factory.GetFlyweight("D");
            fd.Operation(--externalstate);

        }
    }
}
