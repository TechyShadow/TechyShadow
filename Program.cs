using System;

namespace Good_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            evenbettercalculator();
        }
        static void calculator()
        {
            Console.WriteLine("please select number 1: ");
            Double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please select what you want to do (+, -, /, x, %) ");
            Char opt = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("please select number 2: ");
            Double num2 = Convert.ToDouble(Console.ReadLine());

            Double Answer = 0;

            if(opt == '+' )            
            {
                Answer = num1 + num2;
            }

            if(opt == '-' )            
            {
                Answer = num1 - num2;
            }

            if(opt == '/' )            
            {
                Answer = num1 / num2;
            }

            if(opt == 'x' )            
            {
                Answer = num1 * num2;
            }
            if(opt == '%' )            
            {
                Answer = num1 % num2;
            }
            
            Console.WriteLine("Your ans is " + Answer);
        }
        static void repeat()
        {
            Console.WriteLine("Do you want to calculate again? (y/n)");
            Char yorno = Convert.ToChar(Console.ReadLine());
            if(yorno == 'y')
            {
                calculator();
            }
            else if (yorno == 'n')
            {
                Console.WriteLine("Ok byee");
                Console.ReadLine();
            }
        }
        static void goodcalculator()
        {
            calculator();
            repeat();
            calculator();
            repeat();
            calculator();
            repeat();
            calculator();
            repeat();
        }
        static void bettercalculator()
        {
            goodcalculator();
            repeat();
            goodcalculator();
            repeat();
            goodcalculator();
            repeat();
            goodcalculator();
            repeat();
            goodcalculator();
            repeat();
            goodcalculator();
        }
        static void betterercalculator()
        {
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
            bettercalculator();
            repeat();
        }
        static void bestcalculator()
        {
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
            betterercalculator();
            repeat();
        }
        static void evenbettercalculator()
        {
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
            bestcalculator();
            repeat();
        }
    }
}
