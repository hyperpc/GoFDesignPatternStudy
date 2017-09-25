using System;

namespace ch0501_ResponsibilityChain.PurchaseReq
{
    class Director : Approver
    {
        public Director(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 1000.0)
            {
                Console.WriteLine("{0} {1}审批了采购请求#{2}", "主任", name, request.Number);
            }
            else
            {
                if (reporter != null)
                    reporter.ProcessRequest(request);
            }
        }
    }
}
