using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StragetyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //个人所得税
            InterestOperation operation = new InterestOperation(new PersonalTaxStragety());
            Console.WriteLine("个人支付的税{0}",operation.GetTax(5000));

            //企业所得税
            operation = new InterestOperation(new EnterPriseTaxStragety());
            Console.WriteLine("企业支付的税{0}",operation.GetTax(5000));
        }
    }
}
