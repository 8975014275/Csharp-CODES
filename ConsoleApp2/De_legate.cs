using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public delegate void mydel();
    public delegate int mydel2(int a, int b);
    internal class PROGRAM
    {
        static void greet()
        {
            Console.WriteLine("good morning");
        }
        static int Add(int a,int b)
        {
            Console.WriteLine("ADDITION:"+(a+b));
           return a + b;
        }
        static void Main(string[] args)
        {
            mydel d1 = greet;
            d1();
            mydel2 d2 = Add;
           d2(10, 20);
        }
    }

    public delegate void mydel3(int a);
    class overload
    {
        public static void m1(int a)
        {
            Console.WriteLine("in m1"+a);
        }
        public static void square(int n)
        {
            Console.WriteLine("square"+n*n);
        }
        static void Main(string[] args)
        {
            //singlecast

            //  mydel3 d1 = square;
            //multicast-holding referance of more than one function
            mydel3 d2 = square;
            d2 = d2 + m1;
            d2(9);
            
            

        }
    }
    public delegate void myde(int a, int b);//ptactice
    public delegate void delshow();
    public delegate void delhide(int a);
    class prodeleg
    {
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("addition:"+result);
        }
        public static void num(int a)
        {
            Console.WriteLine("num:"+a);
        }
        public static void show()
        {
            Console.WriteLine("show metod");
        }
        public static void substaction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("substraction:" + result);
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplication:" + result);
        }
        static void Main(string[] args)
        {
            myde g = Addition;
            
            //g = substaction;
            //g(15, 5);
            //g = multiplication;
            //g(10, 3);
            g = g + substaction + multiplication;
            g(15, 5);
            delshow g2 = show;
            g2();
            delhide g3 = num;
            num(5);

        }
    }
    public delegate bool del(int n);
    class class2
    {
        static bool isprime(int n)
        {
            bool isprime = true;
           // int c = 0;
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                   isprime= false;
                    break;
                }
            }
            return isprime;
        }
        static bool isleapyear(int yr)
        {
            return yr % 4 == 0;
        }
        static void Main(string[] args)
        {
            del d = isprime;
           // d(89);
           Console.WriteLine(d(89));
            del d1 = isleapyear;
           // d1(2018);
            Console.WriteLine(d1(2022));

        }
    }
    public delegate void dell(int a, int b);
    class anonoms
    {
       
        
        //public static void product(int a,int b)
        //{
        //    Console.WriteLine("prod="+a*b);
        //}
      
        static void Main(string[] args)
        {
            //anonymous
            dell d = delegate (int a, int b)
            {
                Console.WriteLine("prod=" + (a * b));

            };
            d(9, 8);
            //lambda=we can used method body if it is small
            dell d2 = (a, b) =>// Console.WriteLine("area of rectangle=" + (a * b));
            {
                Console.WriteLine("area of rectangle=" + (a * b));
            };
            d2(11, 10);

        }
    } public delegate string delt(string name);//pracice anonyms function
    class anonymsMETHOD
    {
        //public static string Greeting(string name)
        //{
        //    return "Hello" + name + "welcome";
        //}
        static void Main(string[] args)
        {
            delt d = delegate (string name)
            {
               return  "Hello" + name + "welcome";
            };
           string str= d("AKSHAY");
            Console.WriteLine(str);
            ////////////////////////////////
            //lamda function

            delt d2 = (name) => //return "Hello" + name + "welcome";
            {
                return "Hello" + name + "welcome";
            };
            string dt= d2("vivek");
            Console.WriteLine(dt);


        }
    }

    public delegate int dt(int n);
    class delx
    {
        //public static int square(int n)
        //{
        //    return n * n;
        //}
        static void Main(string[] args)
        {
            dt t = (n) => n * n;
          int sq=  t(5);
            Console.WriteLine("squre="+sq);
        }
        
    }
    public delegate void md(int a);
    class demodel
    {
        //public static void fact(int a)
        //{
        //    int fact = 0;
        //    for (int i = 1; i <= a; i++)
        //    {
        //        fact = fact * i;
        //        Console.WriteLine(fact);
        //    }

        //}
        static void Main(string[] args)
        {
            md d2 = (a) =>
            {
                int fact = 1;
                for (int i = 1; i <= a; i++)
                {
                    fact = fact * i;
                   
                }
                Console.WriteLine(fact);


            };
            d2(6);
        }
    }
    class deltype
    {
        static void m1(int a,int b)
        {
            Console.WriteLine("in m1="+(a+b));
        }
        static void m2(string msg)
        {
            Console.WriteLine("welcome");
         }
        static int cube(int x)
        {
            return x * x * x;
        }
        static float areaofCircle(int r)
        {
            return 3.14f * r * r;
        }
        static bool iseven(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            Action<int,int> d1 = m1;
            d1(8, 9);
            Action<string> d2 = m2;
            d2("Good Evening");
            Func<int,int> d3 = cube;
           int d= d3(5);
            Console.WriteLine(d3(5));
            Func<int,float> d4 = areaofCircle;
            d4(7);
            Console.WriteLine(d4(7));
            Func<int, bool> d5 = iseven;
            d5(5);

            Console.WriteLine(d5(5));
           // Predicate<int> d5 = iseven;

           


        }
    }
    class class5
    {
        static double m1(int r,char c)
        {
            return r * 3.14;
        }
        static void m2(byte a,string e)
        {
            Console.WriteLine("in m2"+e+a);
        }
        static bool m3(long m)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Func<int,char,double> f = m1;
           double f1= f(6, 'a');
            Console.WriteLine(f(6, 'a'));
            Action<byte,string > j = m2;
            j(233, "ak");
            Func<long,bool> n = m3;
           bool b= n(253);
            Console.WriteLine(n(253));

        }
    }
    class classdel
    {
        static void greet()
        {
            Console.WriteLine("Happy morning");
        }
        static void m2(int a,int b,Action ac) //as per function 
        {
            Console.WriteLine("Addition="+(a+b));
            ac();
        }
        static void Main(string[] args)
        {
            m2(10, 20, greet);
           // m2(10, 20, () => Console.WriteLine("Byee"));
        }

    }
  

}
