using System;
using System.Linq.Expressions;

namespace TodoAPI
{
    public class GenerateQuestion
    {
        public string expression;
        Random random = new Random();
        public int var1, var2, opt1 = 0, opt2 = 0, opt3 = 0, opt = 0, exp = -1;

        public GenerateQuestion()
        {
            expression = getExpression();
            giveOptions();
        }

        String getExpression()
        {
            var1 = 1; var2 = 100;
            String allExpressions = "+-/*";
            exp = random.Next(0, 4);
            if (exp == 2)
            {
                while (!(var1 % var2 == 0 && var1 > var2))
                {
                    var1 = random.Next(1, 10);
                    var2 = random.Next(1, 10);
                }
            }
            else if (exp == 3)
            {
                while (!(var1 < 5 && var2 < 5))
                {
                    var1 = random.Next(1, 10);
                    var2 = random.Next(1, 10);
                }
            }
            else
            {
                while (var1 < var2)
                {
                    var1 = random.Next(1, 10);
                    var2 = random.Next(1, 10);
                }
            }

            return var1 + allExpressions[exp].ToString() + var2;
        }
        void giveOptions()
        {
            this.opt1 = random.Next(1, 20);
            this.opt2 = random.Next(1, 20);
            this.opt3 = random.Next(1, 20);

            this.opt = random.Next(1, 4);
            if (this.opt == 1)
            {
                this.opt1 = evaluateExpression(expression);
            }
            else if (this.opt == 2)
            {
                this.opt2 = evaluateExpression(expression);
            }
            else
            {
                this.opt3 = evaluateExpression(expression);
            }

            if (opt1 == opt2 || opt3 == opt2 || opt1 == opt3)
            {
                giveOptions();
            }

            return;

        }
        int evaluateExpression(String str)
        {
            int i = 0;
            if (exp == 0)
            {
                i = var1 + var2;
                return i;
            }
            else if (exp == 1)
            {
                i = var1 - var2;
                return i;
            }
            else if (exp == 2)
            {
                i = var1 / var2;
                return i;
            }
            else if (exp == 3)
            {
                i = var1 * var2; ;
                return i;
            }
            return i;
        }
    }
}
