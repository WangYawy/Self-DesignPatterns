using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttern
{

    /// <summary>
    /// 抽象状态类
    /// </summary>
    abstract public class State
    {
        public Account Account { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; } // 利率
        public double LowerLimit { get; set; } //下限
        public double UpperLimit { get; set; } //上限

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Deposit(double amount);
        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public abstract void Withdraw(double amount);
        /// <summary>
        /// 获得利息
        /// </summary>
        public abstract void PayInterest();
    }
    /// <summary>
    /// 透支
    /// </summary>
    public class RedState : State
    {
        public RedState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            this.Interest = 0.0;
            LowerLimit = -100;
            UpperLimit = 0;

        }
        public override void Deposit(double amount)
        {
            this.Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            //没有
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("哪来的钱可以取？");
        }


        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }

    /// <summary>
    /// 没有利息
    /// </summary>
    public class SilverState : State
    {
        public SilverState(double balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            Interest = 0.00;
            LowerLimit = 0.00;
            UpperLimit = 1000.00;
        }
        public SilverState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Interest = 0.00;
            LowerLimit = 0.00;
            UpperLimit = 1000.00;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Balance * Interest;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
            else if (Balance < LowerLimit)
            {
                Account.State = new RedState(this);
            }
        }
    }

    public class GoldState : State
    {
        public GoldState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Interest = 0.05;
            LowerLimit = 1000;
            UpperLimit = 10000;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Balance * Interest;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }
        private void StateChangeCheck()
        {
            if (Balance < 0)
            {
                Account.State = new RedState(this);
            }
           else if (Balance < LowerLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}
