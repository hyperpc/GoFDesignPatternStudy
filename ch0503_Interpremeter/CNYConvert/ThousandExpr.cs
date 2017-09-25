namespace ch0503_Interpreter.CNYConvert
{
    class ThousandExpr : Expression
    {
        public override string Five()
        {
            return "伍仟";
        }

        public override string Four()
        {
            return "肆仟";
        }

        public override int Multiplier()
        {
            return 1000;
        }

        public override string Nine()
        {
            return "玖仟";
        }

        public override string One()
        {
            return "壹仟";
        }
    }
}
