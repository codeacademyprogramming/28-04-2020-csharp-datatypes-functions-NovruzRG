using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_04_2020_csharp_datatypes_functions_NovruzRG
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose homework number and press Enter");
            Console.WriteLine("1 for How many digits you enter");
            Console.WriteLine("2 for Sade ve Murekkeb");
            Console.WriteLine("3 for Month");
            var choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("You pressed 1 for How many digits you enter");
            Start:
                Console.WriteLine("reqemi daxiledin");
                int A = Convert.ToInt32(Console.ReadLine());
                int D, C;
                D = 10;
                C = 1;
                for (; A % D != A; D *= 10)
                {
                    C++;
                }
                Console.WriteLine("Daxil etidiyin reqem " + C + " sinvoldan ibaretdir.");
                goto Start;
            }
            else if (choose == 2)
            {
                Console.WriteLine("You pressed 2 for Sade ve Murekkeb");
            Start:
                Console.WriteLine("daxil edin");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n <= 1)
                {
                    Console.WriteLine("ne sade ne murekkeb", n);
                }
                int a = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("sade", n);
                }
                else
                {
                    Console.WriteLine("murekkeb");
                }
                goto Start;
            }
            else if (choose == 3)
            {
                Console.WriteLine("You pressed 3 for Month");
            Start:
                Console.WriteLine("Ayin sira nömresini daxil edin");
                int F = Convert.ToInt32(Console.ReadLine());
                if (F < 1 || F > 12)
                {
                    Console.WriteLine("1-12 ye qeder secin");
                    goto Start;
                }
                else if (F == 12 || F <= 2)
                {
                    Console.WriteLine("Qish");
                }
                else if (F <= 5)
                {
                    Console.WriteLine("Yaz");
                }
                else if (F <= 8)
                {
                    Console.WriteLine("Yay");
                }
                else
                {
                    Console.WriteLine("Payiz");
                }
                goto Start;
            }

        }
    }
}
