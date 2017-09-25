using System;

namespace ch0501_ResponsibilityChain.PurchaseReq
{
    class VicePresident : Approver
    {
        public VicePresident(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if(request.Amount<25000)
                Console.WriteLine("{0} {1}审批了采购请求#{2}", "副董", name, request.Number);
            else
            {
                if (reporter != null)
                    reporter.ProcessRequest(request);
            }
        }
    }
}
