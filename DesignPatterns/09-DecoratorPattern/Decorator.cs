using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DecoratorPattern
{
    /// <summary>
    /// 装饰抽象类，要让装饰完全取代抽象组件，所以继承Phone
    /// </summary>
    abstract public class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone phone)
        {
            this.phone = phone;
        }

        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }

    /// <summary>
    /// 贴膜，即具体装饰者
    /// </summary>
    public class Sticker : Decorator
    {
        public Sticker(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加新行为
            AddSticker();
        }

        public void AddSticker()
        {
            Console.WriteLine("{0}手机有贴膜了", this.Name);
        }
    }

    /// <summary>
    /// 手机挂件，也是具体装饰者
    /// </summary>
    public class Accessories : Decorator
    {
        public Accessories(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            // 添加新行为
            AddAccessories();
        }

        public void AddAccessories()
        {
            Console.WriteLine("{0}手机有挂件了", this.Name);
        }
    }
}
