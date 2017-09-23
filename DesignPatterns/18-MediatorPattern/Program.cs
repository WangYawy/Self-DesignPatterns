using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCardPartner patner1 = new PartnerA();
            AbstractCardPartner patner2 = new PartnerB();
            AbstractMediator mediator = new MediatorPater(patner1, patner2);
            patner1.MoneyCount = 100;
            patner2.MoneyCount = 100;

            patner1.ChangeCount(5, mediator);
            Console.WriteLine("A.MoneyCount = {0} , B.MoneyCount = {1}", patner1.MoneyCount, patner2.MoneyCount);

            patner2.ChangeCount(50, mediator);
            Console.WriteLine("A.MoneyCount = {0} , B.MoneyCount = {1}", patner1.MoneyCount, patner2.MoneyCount);
        }
    }
}
