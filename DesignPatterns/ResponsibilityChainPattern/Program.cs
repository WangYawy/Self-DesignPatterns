using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 请求
            PurchaseRequest request1 = new PurchaseRequest(800,"手机");
            PurchaseRequest request2 = new PurchaseRequest(1500,"Note");
            PurchaseRequest request3 = new PurchaseRequest(4000,"Computer");

            Approver manager = new Manager("管理员");
            Approver Vp = new VicePressident("副总");
            Approver Pre = new President("总经理");
            //责任链
            manager.NextApprover = Vp;
            Vp.NextApprover = Pre;

            //处理请求
            manager.ProcessRequest(request1);
            manager.ProcessRequest(request2);
            manager.ProcessRequest(request3);
        }
    }
}
