using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 采购请求
    /// </summary>
    public class PurchaseRequest
    {
        public double Amount { get; set; }
        public string ProductName { get; set; }

        public PurchaseRequest(double amount, string productName)
        {
            this.Amount = amount;
            this.ProductName = productName;
        }
    }

    /// <summary>
    /// 审批人
    /// </summary>
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }
        public string Name { get; set; }
        public Approver(string name)
        {
            this.Name = name;
        }
        public abstract void ProcessRequest(PurchaseRequest request);
    }

    //ConcreteHandler
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 1000)
            {
                Console.WriteLine("{0}-{1} 通过 {2}", this, this.Name, request.ProductName);
            }
            else
            {
                Console.WriteLine("{0}-{1} 没有权限，向上级 {2} 反馈", this, this.Name, NextApprover.Name);
                NextApprover.ProcessRequest(request);
            }
        }
    }
    // 副总
    public class VicePressident : Approver
    {
        public VicePressident(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 2000)
            {
                Console.WriteLine("{0}-{1} 通过 {2}", this, this.Name, request.ProductName);
            }
            else
            {
                Console.WriteLine("{0}-{1} 没有权限，向上级 {2} 反馈", this, this.Name, NextApprover.Name);
                NextApprover.ProcessRequest(request);
            }
        }
    }
    // 总经理
    public class President : Approver
    {
        public President(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 3000)
            {
                Console.WriteLine("{0}-{1} 通过 {2}", this, this.Name, request.ProductName);
            }
            else
            {
                Console.WriteLine("等开会讨论一下再说");
            }
        }
    }


}
