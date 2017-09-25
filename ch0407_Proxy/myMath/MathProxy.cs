namespace ch0407_Proxy.myMath
{
    class MathProxy : IMath
    {
        Math math;
        public MathProxy()
        {
            math = new Math();
        }

        public double Add(double x, double y)
        {
            return math.Add(x, y);
        }

        public double Div(double x, double y)
        {
            return math.Div(x, y);
        }

        public double Mul(double x, double y)
        {
            return math.Mul(x, y);
        }

        public double Sub(double x, double y)
        {
            return math.Sub(x, y);
        }
    }
}
