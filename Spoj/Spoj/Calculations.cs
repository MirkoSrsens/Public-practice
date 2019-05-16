using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj
{
    internal sealed class Calculations
    {
        private static string FinalResult = "";

        internal static void PrintResults()
        {
            Console.WriteLine(FinalResult);
        }

        internal static void CalculateX(string input)
        {
            var stack = new Stack<string>();
            var stogNumber = new Stack<Stogs>();
            foreach (var item in input.Split(' '))
            {
                stack.Push(item);
            }


            while (stack.Count > 0)
            {
                var element = stack.Pop();
                Stogs calculationRes = null;
                if (element == "X")
                {
                    stogNumber.Push(new Stogs() { Number = 1, Unknown = true });
                }
                else if (int.TryParse(element, out int number))
                {
                    stogNumber.Push(new Stogs() { Number = number, Unknown = false });
                }
                else if ((calculationRes = IsOperation(element, stogNumber.Pop(), stogNumber.Pop())) != null)
                {
                    stogNumber.Push(calculationRes);
                }
            }

            var result = stogNumber.Pop();
            var X = stogNumber.Pop();

            if ((result.Number - (X.Link != null ? X.Link.Number : 0)) % X.Number != 0)
            {
                FinalResult = string.Concat(FinalResult, "Err", " ");
            }
            else
            {
                int totalRes = (result.Number - (X.Link != null ? X.Link.Number : 0)) / X.Number;
                FinalResult = string.Concat(FinalResult, totalRes, " ");
            }
        }

        public static Stogs IsOperation(string input, Stogs left, Stogs right)
        {
            switch (input)
            {
                case "+":
                    return Stogs.Plus(left, right);
                case "-":
                    return Stogs.Minus(left, right);
                case "*":
                    return Stogs.Multiply(left, right);
                default:
                    return null;
            }
        }
    }
}
