using System;
using System.Collections;

namespace ch0503_Interpreter.CNYConvert
{
    public class Client
    {
        public static void Test()
        {
            string chinese = "壹仟伍佰玖拾伍圆";
            Context context = new Context(chinese);
            ArrayList parse = new ArrayList();
            parse.Add(new ThousandExpr());
            parse.Add(new HundredExpr());
            parse.Add(new TenExpression());
            parse.Add(new OneExpression());

            foreach (Expression expr in parse)
                expr.Interpreter(context);

            Console.WriteLine("{0} = {1}", chinese, context.Output);
        }
    }
}
