namespace ch0501_ResponsibilityChain.PurchaseReq
{
    abstract class Approver
    {
        protected string name;
        protected Approver reporter;
        public Approver(string name)
        {
            this.name = name;
        }

        public void SetReporter(Approver reporter)
        {
            this.reporter = reporter;
        }
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
