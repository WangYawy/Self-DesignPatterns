using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttern
{
    public class Account
    {
        public State State { get; set; }
        public string Owner { get; set; }
        public Account(string owner)
        {
            this.Owner = owner;
            this.State = new SilverState(0, this);
        }

        public double Balance
        {
            get
            {
                return State.Balance;
            }
        }
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("存款金额{0:C}", amount);
            Console.WriteLine("账户余额{0:C}", Balance);
            Console.WriteLine("账户状态{0}",this.State.GetType().Name);
            Console.WriteLine();
        }
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("存款金额{0:C}", amount);
            Console.WriteLine("账户余额{0:C}", Balance);
            Console.WriteLine("账户状态{0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void PatInerest()
        {
            State.PayInterest();
            Console.WriteLine("Interest ");
            Console.WriteLine("账户余额{0:C}", Balance);
            Console.WriteLine("账户状态{0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}
