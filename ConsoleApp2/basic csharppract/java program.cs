using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //public class Testv
    //{
    //   int Testv(int i)
    //    {
    //        Console.WriteLine("test2");
    //        return i;
    //    }
    //    Testv()
    //    {
    //        Console.WriteLine("TEST1");
    //    }
    //   public static void Main(string[] args)
    //    {
    //        Testv a=new Testv(5);
    //    }
    //}// Compile time exception in line 10
    //public class TST
    //{
    //    void display(Object o)
    //    {
    //        Console.WriteLine("Object");
    //    }
    //    void display(string str)
    //    {
    //        Console.WriteLine("string");
    //    }
    //      public static void Main(string[] args)
    //    {
    //        new TST().display(null);
    //    }
    //    // Ans--> string
    //}

    //public class Mett1
    //{
    //    public static void check()
    //    {
    //        Console.WriteLine("1");
    //    }

    //    public static int check()
    //    {
    //        return 1;
    //    }
    //    public static void Main(string[] args)
    //    {
    //        check();
    //    }//ans the two method compile time error
    //}
    //public class qq40
    //{
    //    public static void Main(string[] args)
    //    {
    //        sum(10, 20);
    //    }
    //    static void sum(long l1, long l2)
    //    {
    //        Console.WriteLine("long");

    //    }
    //    static void sum(float f1, float f2)
    //    {
    //        Console.WriteLine("float");
    //    }
    //}// ans long
    //public class tst extends Thread
    //{
    //    public void run()
    //    {
    //        Console.WriteLine("start");
    //        //yield();
    //        Console.WriteLine("end");
    //    }
    //    public static void Main(string[] args)
    //    {
    //        (new tst()).run();
    //    }
    //}
    //class Parent
    //{
    //    public final void helloworld()
    //    {
    //        Console.WriteLine("Base::show() called");
    //    }

    //}
    //class child extend Parent
    //{
    //      public  void helloworld1()
    //      {

    //      }
    //}
    class abd
    {
        public static void Main(string[] args)
        {
            int i, j;
            i = 100;
            j = 200;
            while (++i < --j) ;
            Console.WriteLine("midpoint is:" + i);
        }//midpoint is 150
    }
    class Test1
    {
        static void pupAge()
        {
            int age = 0;
            age = age + 7;
            Console.WriteLine("Puppy age:" + age);
        }
        static void Main(string[] args)
        {
            Test1 test = new Test1();
            Test1.pupAge();
        }
    }//puppy age is 7
    //public class Test extends Thread
    //{
    //    public void run()
    //    {
    //     Console.WriteLine("RUN METHOD");
    //    }
    //    static public void Main(string[] args)
    //    {
    //      Test t1 = new Test();
    //      Test t2 = new Test();

    //       t1.start();
    //        t2.start();
    //    }

    //}

        

}

