namespace ch0503_Interpreter.CNYConvert
{
    class TenExpression:Expression
    {
        public override string Five()
        {
            return "伍拾";
        }

        public override string Four()
        {
            return "肆拾";
        }

        public override int Multiplier()
        {
            return 10;
        }

        public override string Nine()
        {
            return "玖拾";
        }

        public override string One()
        {
            return "壹拾";
        }
    }
}
