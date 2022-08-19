using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class abs
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
        label:
            i++;
            j += i;
            if (i < 10)
            {
                Console.Write(i + " ");
                goto label;
            }

        }//ans it will print 1-9
    }
    class ktm
    {
        static void Main()
        {
            int m = 10; int n = 7;
            while (m % n >= 0)
            {
                m = m + 1; n = n + 2;
            }
        }//ans infinite times
    }
    class test
    {
        static void Main(string[] args)
        {
            int val;
            for (val = -5; val <= 5; val++)
            {
                switch (val)
                {
                    case 0:
                        Console.Write("India");
                        break;
                }
                if (val > 0)
                {
                    Console.Write("B");

                }
                else if (val < 0)
                    Console.Write("X");

            }//ans XXXXXIndiaBBBBB
        }
    }
    class arprogram
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 };
            a[1] = new int[3] { 9, 2, 7 };
            Console.WriteLine(a[1].GetUpperBound(0));
        }//ANS-2
    }
    class scope
    {
        int x = 10;
        static int y = 20;
        public static void Main()
        {
            int x = 100; int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(scope.y);
        }//ANS 100,200,20
    }
    class srty
    {
        static void Main(string[] args)
        {
            char[]arr=new char[] {'k','i','c','i','t'};
            foreach(int i in arr)
            {
                Console.WriteLine((char)i);
            }
        }
    }


}
