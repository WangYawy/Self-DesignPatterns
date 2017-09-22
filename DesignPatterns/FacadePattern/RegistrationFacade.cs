using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class RegistrationFacade
    {
        private RegisterCourse course;
        private NofifyStudent nofify;

        public RegistrationFacade()
        {
            course = new RegisterCourse();
            nofify = new NofifyStudent();
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            if (course.CheckAvailable(courseName))
            {
                return nofify.Notify(studentName);
            }
            return false;
        }
    }

    /// <summary>
    /// 相当于子系统A
    /// </summary>
    public class RegisterCourse
    {
        public bool CheckAvailable(string courseName)
        {
            Console.WriteLine("正在验证课程 {0} 是否已满", courseName);
            return true;
        }
    }
    /// <summary>
    /// 相当于子系统B
    /// </summary>
    public class NofifyStudent
    {
        public bool Notify(string studentName)
        {
            Console.WriteLine("正在向 {0} 发出通知",studentName);
            return true;
        }
    }
}
