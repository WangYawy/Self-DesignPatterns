using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateParttern
{
    // 完善中介者模式

    /// <summary>
    /// 抽象牌友类
    /// </summary>
    public abstract class AbstractCardPartner
    {
        public int MoneyCount { get; set; }
        public AbstractCardPartner()
        {
            MoneyCount = 0;
        }

        public abstract void ChangeCount(int count, AbstractMediator mediator);
    }

    public class ParternA : AbstractCardPartner
    {
        public override void ChangeCount(int count, AbstractMediator mediator)
        {
            mediator.ChangeCount(count);
        }
    }
    public class ParternB : AbstractCardPartner
    {
        public override void ChangeCount(int count, AbstractMediator mediator)
        {
            mediator.ChangeCount(count);
        }
    }
    /// <summary>
    /// 抽象状态类
    /// </summary>
    public abstract class WinState
    {
        public AbstractMediator mediator;
        public abstract void ChangeCount(int count);
    }
    /// <summary>
    /// A赢状态类
    /// </summary>
    public class AWinState : WinState
    {
        public AWinState(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }
        public override void ChangeCount(int count)
        {
            foreach (AbstractCardPartner p in mediator.list)
            {
                ParternA a = p as ParternA;
                if (a != null)
                {
                    a.MoneyCount += count;
                }
                else
                {
                    p.MoneyCount -= count;
                }
            }
        }
    }

    public class BWinState : WinState
    {
        public BWinState(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }
        public override void ChangeCount(int count)
        {
            foreach (AbstractCardPartner p in mediator.list)
            {
                ParternB b = p as ParternB;
                if (b != null)
                {
                    b.MoneyCount += count;
                }
                else
                {
                    p.MoneyCount -= count;
                }
            }
        }
    }
    /// <summary>
    /// 初始化状态
    /// </summary>
    public class InitState : WinState
    {
        public InitState()
        {
            Console.WriteLine("游戏才刚刚开始...");
        }
        public override void ChangeCount(int count)
        {
            return;
        }
    }

    /// <summary>
    /// 抽象中介者类
    /// </summary>
    public abstract class AbstractMediator
    {
        public List<AbstractCardPartner> list = new List<AbstractCardPartner>();
        public WinState State { get; set; }

        public AbstractMediator(WinState state)
        {
            this.State = state;
        }

        public void Enter(AbstractCardPartner partner)
        {
            list.Add(partner);
        }

        public void Exit(AbstractCardPartner partner)
        {
            list.Remove(partner);
        }

        public void ChangeCount(int count)
        {
            State.ChangeCount(count);
        }
    }

    public class MediatorPater : AbstractMediator
    {
        public MediatorPater(WinState state) : base(state)
        {
        }
    }
}
