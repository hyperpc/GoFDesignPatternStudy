using System;

namespace ch0501_ResponsibilityChain.PurchaseReq
{
    class President : Approver
    {
        public President(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000)
                Console.WriteLine("{0} {1}审批了采购请求#{2}", "董事长", name, request.Number);
            else
            {
                Console.WriteLine("采购请求#{0}需要开会决定", request.Number);
            }
        }
    }
}
