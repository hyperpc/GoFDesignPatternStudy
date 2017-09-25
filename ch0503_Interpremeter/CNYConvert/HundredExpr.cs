namespace ch0503_Interpreter.CNYConvert
{
    class HundredExpr : Expression
    {
        public override string Five()
        {
            return "伍佰";
        }

        public override string Four()
        {
            return "肆佰";
        }

        public override int Multiplier()
        {
            return 100;
        }

        public override string Nine()
        {
            return "玖佰";
        }

        public override string One()
        {
            return "壹佰";
        }
    }
}
