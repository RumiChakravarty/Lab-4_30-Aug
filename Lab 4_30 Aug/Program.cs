using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_4_30_Aug
{
    class Program
    {
        static string ans;
        static int valueInt;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!\n");

            Console.Write("Enter an integer that's greater than 1 but less than 10 : ");

            do
            {
               
                //Console.Write($"Enter an integer that's greater thean 1 but less than {FactorialValue(valueInt)}: ");
                valueInt = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial of {valueInt} is {Factorial(valueInt)}");
                // FactorialValue(valueInt);
                // Console.WriteLine($"Factorial of {valueInt} is {FactorialValue(valueInt)}");
                //if (valueInt > 0 && valueInt < 10)
                //{
                //    for (int i = 1; i <= valueInt; i++)
                //    {
                //        resultFinal = resultFinal * i;
                //    }
                //}




                //Console.WriteLine(objClass.FactorialValue(4));
                
                Console.Write("\nContinue ?(y/n) :");
                ans = Console.ReadLine();
                Console.WriteLine();
                if(ans == "y")
                Console.Write($"Enter an integer that's greater than 1 but less than {Factorial(valueInt)}: ");

            } while (ans == "y");


        }

        static long Factorial(int num)
        {
            if (num == 0)
                return 1;
            return num * Factorial(num - 1);
        }

        //static  long FactorialValue(int num)
        //{
        //     long resultFinal = 1;
        //    if (valueInt > 0 && valueInt < 10)
        //    {
        //        for (int i = 1; i <= valueInt; i++)
        //        {
        //            resultFinal = resultFinal * i;
        //        }
        //    }

        //    return resultFinal;
        //}

    }
}
