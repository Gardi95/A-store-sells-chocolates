using System;

namespace store_sells_chocolates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            double a, b = 0, z = 0;
            double c = 0, d, q = 0;
            double e = 0, f, k = 0;
            double g = 0, h, x = 0;
          

            Console.WriteLine("please Enter the amount");
            a = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            if (a >= 20)
            {
                b = a * i;
                z = b * 0.4;
                Console.WriteLine("praise befor deskawnd " + b);
                Console.WriteLine("praise after deskawnd " + z);
                Console.WriteLine("-----------------");
            }  

            if (d >= 10 && d <= 19)
            {
                c = d * i;
                q = c * 0.3;

                Console.WriteLine("praise befor deskawnd " + c);
                Console.WriteLine("praise after deskawnd " + q);
                Console.WriteLine("-----------------");

            }

            if (f >= 5 && f <= 10)
            {
                e = f * i;
                k = e * 0.2;

                Console.WriteLine("praise befor deskawnd " + e);
                Console.WriteLine("praise after deskawnd " + k);
                Console.WriteLine("-----------------");

            }

            if (h <= 5)
            {
                g = h + i;
                x = g * i;

                Console.WriteLine("praise befor deskawnd " + g);
                Console.WriteLine("praise after deskawnd " + x);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("the total praise befor deskawnd is: " );
            Console.WriteLine(b + c + e + g);

            Console.WriteLine("the total praise after deskawnd is: " );
            Console.WriteLine(z + q + k + x);
           
            
            
            




        }
    }
}
