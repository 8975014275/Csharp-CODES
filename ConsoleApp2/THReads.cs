using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class threaddemo
    {
        static void m1()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void m2()
        {
            Console.WriteLine("WELCOME");
        }
        static void Main(string[] args)
        {
            threaddemo P=new threaddemo();

            Console.WriteLine("main starts");
            Thread t1=new Thread(m1);
            t1.Start();
            Thread T2 = new Thread(P.m2);
            T2.Start();
            for(int i = 1; i <=100; i++)
            {
                Console.WriteLine("GM");
            }
            Console.WriteLine("Main end");
        }
    }
    class thredconcept
    {//thread=an execution of a program we can use multiple thread to perform,
     //differant tasks of our progrem at the same time.
     //current thread running in main thread
     //using system.Threading;
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("function1=" + i);
            }
        }
        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("function2="+i);
                if(i==25)
                {
                    Console.WriteLine("thread is going to sleep for 8 sec");
                    Thread.Sleep(8000);
                }
            }

        }
        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("function3=" + i);
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3=new Thread(func3);
            
            t1.Start();
            t2.Start();
            t3.Start();
            //func1();
            //func2();
            //func3();
        }//asked question=countdown,countup.


    }
}
 