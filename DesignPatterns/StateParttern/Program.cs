using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Fly");

            // 存钱
            account.Deposit(1000);
            account.Deposit(200);
            account.Deposit(600);

            account.PatInerest();

            account.Withdraw(1800);
            account.Withdraw(500);


            // 中介者和状态者模式
            AbstractCardPartner A = new ParternA();
            AbstractCardPartner B = new ParternB();
            A.MoneyCount = 20;
            B.MoneyCount = 20;

            AbstractMediator mediator = new MediatorPater(new InitState());
            // A ，B 参加
            mediator.Enter(A);
            mediator.Enter(B);
            //A赢了
            mediator.State = new AWinState(mediator);
            mediator.ChangeCount(5);
            Console.WriteLine("A 现在的钱是{0}",A.MoneyCount);
            Console.WriteLine("B 现在的钱是{0}", B.MoneyCount);

            // B赢了
            mediator.State = new BWinState(mediator);
            mediator.ChangeCount(10);
            Console.WriteLine("A 现在的钱是{0}", A.MoneyCount);
            Console.WriteLine("B 现在的钱是{0}", B.MoneyCount);
        }
    }
}
