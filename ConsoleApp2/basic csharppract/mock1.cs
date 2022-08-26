using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class mock1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int n, sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                n = a[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                if (isprime == true)
                {
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];
                }
            }
            Console.WriteLine(sum);


        }
    }
    class arrayreverse
    {
        static void Main(string[] args)
        {
            int[] c = new int[6];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", c));
            for (int i = c.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(c[i]);
            }


        }

    }
    class arreverse1
    {
        static void Main(string[] args)
        {
            int[] d = new int[6];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("///////////////");
            foreach (int p in d)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("//////////////////////");
            Array.Reverse(d);
            foreach (int c in d)
            {
                Console.WriteLine(c);
            }

        }
    }
    class res
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            //int[] a = { 4, 6, 8, 9, 5 };
            //foreach(int p in a)
            //{
            //    Console.WriteLine(p);
            //}
            int j = a.Length - 1;
            for (int i = 0; i <= a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine(String.Join(" ", a));




        }
    }
    class pale
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter string");
            str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Array.Reverse(a);
            string str_reverse = new string(a);
            if (str_reverse == str)
            {
                Console.WriteLine("paleendrom string");

            }
            else
                Console.WriteLine("not palendrom");


        }
    }
    class revst//string reverse method
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter string");
            str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Array.Reverse(a);
            string str_reverse = new string(a);
            Console.WriteLine(str_reverse);
        }
    }
    class strsort//alphabet ordeer sorting  
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Array.Sort(a);
            string newst = new string(a);
            Console.WriteLine(a);
        }
    }


    class revst1//string reverse alternate method
    {
        static void Main(string[] args)
        {
            string str, revstr = "";
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr = revstr + str[i];
            }
            Console.WriteLine(revstr);
        }
    }
    class find
    {
        static void Main(string[] args)
        {
            int[] s = new int[5];
            Console.WriteLine("enter the element");
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the number is searche");
            int num = int.Parse(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == num)
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("not present ");
            }

        }
    }
   
    public abstract class abst//abstraction concept
    {
        public abstract void m1();
        public void m2()
        {
            Console.WriteLine("m2");
        }
    }
    class b : abst
    {
        public override void m1()
        {
            Console.WriteLine("m1");
        }
    }
    class c
    {
        static void Main(string[] args)
        {
            b c = new b();
            c.m1();
            c.m2();
        }
    }
    public interface A//interface concept
    {
        void m1();
    }
    public interface n
    {
        void m2();
    }
    class B : A, n
    {
        public void m1()
        {
            Console.WriteLine("m1");
        }
        public void m2()
        {
            Console.WriteLine("m2");
        }
    }
    class d
    {
        static void Main(string[] args)
        {
            B v = new B();
            v.m1();
            v.m2();
        }
    }
    class looping
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);

            //int i = 1;
            //while(i<=5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //for(int i=1;i<=5;i++)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
    class fac
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine(fact);
        }
    }
    class od
    {
        static void Main(string[] args)
        {
            int remainder;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            remainder = num % 2;
            if (remainder == 0)
            {
                Console.WriteLine("number is even");
            }
            else
                Console.WriteLine("odd number");

        }
    }
    class fib
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("enter the terms");
            int terms = int.Parse(Console.ReadLine());
            for (int i = 0; i <= terms; i++)
            {
                c = a + b;
                Console.Write(a + " ");
                a = b;
                b = c;
            }
        }
    }
    class search
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.Write(a[i]);
                }

            }



        }
    }
    class serch
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("enter the array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("present number");
            }
            else
            {
                Console.WriteLine("not present");
            }

        }
    }
    class dg
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter string");
            str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            if (str == rev)
            {
                Console.WriteLine("pallendrom string");
            }
            else
                Console.WriteLine("not pallendrom");

        }
    }
    class toggle
    {
        static void Main(string[] args)
        {
            string str;
            string newstr = "";
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }
                else
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
    class chj
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }

            //Console.WriteLine(String.Join(" ",a));
            //Array.Reverse(a);
            //Console.WriteLine(String.Join(" ",a));
            ////foreach(int b in a)
            ////{
            ////    Console.WriteLine(b);
            ////}

        }
    }
    class occeren
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1; 
                bool isvisited=false;
                for(int k=i-1;k>=0;k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if (a[i]==a[j])
                        {
                            
                            count++;
                        }
                       // if(count==1)
                        
                    }
                    
                    
                    Console.WriteLine(a[i]+" "+count);
                }
            } 
        }
    }
   
    class chjw
    {
        static void Main(string[] args)
        {
            char[] a = new char[5];
            Console.WriteLine("enter the array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] =char.Parse(Console.ReadLine());
            }
            Console.Write(String.Join(" ",a));
            int j=a.Length-1;
            for (int i = 0; i <= a.Length/2; i++)
            {
                char temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine("//////////////");
            Console.Write(String.Join(" ",a));

        }
    }

    
}