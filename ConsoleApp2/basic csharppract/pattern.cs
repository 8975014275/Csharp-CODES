using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class pyra
    {
        static void Main(string[] args)
        {
            //5 is rows ,rows you can put
            for (int x = 1; x <= 5; x++)//outer loop print 5 rows
            {
                for (int y = 1; y <= 5 - x; y++)//print empty space
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= x; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class pat22
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 5; i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    class pat23  
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
    class pat24
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class pt24
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
    class pat25
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
    class fibonech
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            for(int i=0;i<=10;i++)
            {
                int c = a + b;
                Console.Write(a+" ");
                a = b;
                b= c;
            }
        }
    }
    class p
    {
        static void Main(string[] args)
        {
            int x = 8;
            int b = 16;
            int c = 64;
            x /= c /= b;
            Console.WriteLine(x+" "+b+" "+c);
        }
    }
}
