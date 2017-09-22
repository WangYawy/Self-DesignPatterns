using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 选课，验证是否有课，通知学生
            var course = "外太空";
            var student = "Ming";
            RegistrationFacade facade = new RegistrationFacade();
            if (facade.RegisterCourse(course, student))
            {
                Console.WriteLine("选课成功");
            }
            else
            {
                Console.WriteLine("选课失败");
            }
        }
    }
}
