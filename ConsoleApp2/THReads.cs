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
    class progrthread
    {
        public void test1()
        {
            lock (this)
            for (int i=0;i<=10;i++)
            {
                
                Console.WriteLine("test1 is running"+i.ToString());

            }
        }
        public void test2()
        {
            lock (this)
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test2 is running" + i.ToString());

            }
        }
        public void test3()
        {
            lock (this)//for synchronus threading remember non static method
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test3 is running" + i.ToString());

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main is started");
            progrthread p = new progrthread();
            Thread t1 = new Thread(p.test1);
            Thread t2 = new Thread(p.test2);
            Thread t3 = new Thread(p.test3);
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
            Console.WriteLine("main is terminated");

        }
    }
   
}
 