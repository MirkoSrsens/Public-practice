using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spoj;

public class Program
{
    static void Main(string[] args)
    {
        //Calculations.CalculateX("231 * * + 1 2 + X 4 + 5 6");
        //Calculations.CalculateX("413 * * - + 2 + 9 7 9 3 * X 3");
        //Calculations.CalculateX("-22 - + 2 + 4 * 3 - - 6 4 9 X");
        //Calculations.CalculateX("15 - - X - - 1 7 7 * 5 - 3 2");
        //Calculations.CalculateX("-51 - * 5 0 + X * + 0 9 - 5 0");
        //Calculations.CalculateX("-305 * 5 + + - 6 * 7 9 0 - X 9");
        //Calculations.CalculateX("-120 - - + X + 0 1 1 * 7 * 3 6");
        //Calculations.CalculateX("-10 - * 8 2 + 9 - * - 4 1 8 X");
        //Calculations.CalculateX("18 * + - 1 9 + 3 3 * X - 6 9");
        //Calculations.CalculateX("114 - - * 9 + 6 8 * + 2 1 3 X");

        Manager.StartService();
        Calculations.PrintResults();
        Console.ReadKey();
    }
}
