using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 以手机需要贴膜、挂件为例
            // 定义手机 
            Phone phone = new ApplePhone();
            phone.Name = "苹果";
            // 贴膜
            Decorator withSticker = new Sticker(phone);
            withSticker.Print();
            Console.WriteLine();
            // 挂件
            Decorator withAccessories = new Accessories(phone);
            withAccessories.Print();
            Console.WriteLine();

            // 同时有贴膜、挂件，可把贴膜、挂件当作phone传入
            phone.Name = "MEIZU";
            Sticker sticker = new Sticker(phone);
            Accessories accessoires = new Accessories(sticker);
            accessoires.Print();

        }
    }
}
