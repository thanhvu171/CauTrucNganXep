using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucNganXep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            Console.WriteLine("Nhap co so he so 10: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap co so can doi: ");
            x = int.Parse(Console.ReadLine());

            Stack A = new Stack();
            while (n > 0)
            {
                A.push(n % x);
                n = n / x;
            }
            int giaTri;
            Console.WriteLine($"Bieu dien he {x}: ");
            while (!A.isEmpty())
            {
                if (x == 16)
                {
                    giaTri = A.pop();
                    switch (giaTri)
                    {
                        case 10:
                            Console.WriteLine("A");
                            break;
                        case 11:
                            Console.WriteLine("B");
                            break;
                        case 12:
                            Console.WriteLine("C");
                            break;
                        case 13:
                            Console.WriteLine("D");
                            break;
                        case 14:
                            Console.WriteLine("E");
                            break;
                        case 15:
                            Console.WriteLine("F");
                            break;
                        default:
                            Console.WriteLine(giaTri);
                            break;
                    }
                }
                else
                    Console.WriteLine(giaTri);
            }
            Console.ReadKey();
        }
    }
}
