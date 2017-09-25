namespace ch0401_Adapter.Cleanor
{
    public class Client
    {
        public static void Test()
        {
            IExtra e = new Facility();
            Jobs(e);

            IClean c1 = new Office();
            IClean c2 = new Workshop();
            Jobs(c1);
            Jobs(c2);
        }

        private static void Jobs(IClean job)
        {
            if (job is IClean)
                job.makeClean();

            if (job is IExtra)
                ((IExtra)job).takeCare();
        }
    }
}
