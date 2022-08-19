using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class abstracprogram//abstraction example
    {
        public abstract void m1();
        public void m2()
        {
            Console.WriteLine("m2");
        }
    }
    class bchild : abstracprogram
    {
        public override void m1()
        {
            Console.WriteLine("m1");
        }
    }
    class classc
    {
        static void Main(string[] args)
        {
            bchild b = new bchild();
            b.m1();
            b.m2();

        }
    }




    class overloadm//method overloading
    {
        public void calculate(int x, int y, int z)
        {
            Console.WriteLine("add=" + (x + y + z));
        }
        public void calculate(int x, int y)
        {
            Console.WriteLine("sub=" + (x - y));
        }
        public void calculate(float x, float y)
        {
            Console.WriteLine("mul=" + (x * y));
        }
        public void calculate(int x, float y)
        {
            Console.WriteLine("div=" + (x * y));
        }
        static void Main(string[] args)
        {
            overloadm t = new overloadm();
            t.calculate(5, 4, 6);
            t.calculate(5, 4);
            t.calculate(5.5f, 4.5f);
            t.calculate(25, 5.5f);

        }

    }


    class methoveride//method overide
    {
        public virtual void m1()
        {
            Console.WriteLine("method of base class");
        }
    }
    class methadA : methoveride
    {
        public override void m1()
        {
            Console.WriteLine("method of derrived  class");
        }
    }
    class cmethod
    {
        static void Main(string[] args)
        {
            methadA b = new methadA();
            b.m1();
        }
    }
    class people//constructor overloading
    {
        public people()
        {
            Console.WriteLine("people are good");
        }
        public people(int a,int b)
        {
            Console.WriteLine("sum="+(a+b));
        }
        public people(int a,int b,int c)
        {
            Console.WriteLine("addition="+(a+b+c));
        }
        static void Main(string[] args)
        {
            people p=new people(5,8,9);
        }
    }
    class Example1 //cpoy constructor 
    {
        string name;
        int age;
        public Example1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }  
        public Example1(Example1 e) //cpoy constructor
        {
            this.name=e.name;
            this.age=e.age;

        }
        public void getdata()
        {
            Console.WriteLine("name is:"+name);
            Console.WriteLine("age is:"+age);
        }
    }
  
   
    class progress
    {
        static void Main(string[] args)
        {
            Example1 e=new Example1("AKSHAY",25);
            e.getdata();
            Example1 e1 = new Example1(e);
            e1.getdata();

        }
    }
    class privateconstructor//use of private constructor
    {
        private privateconstructor()
        {

        }
        public static void gettime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    class privconst
    {
        static void Main(string[] args)
        {
            privateconstructor.gettime();

        }
    }

    class employee85//encapsulation concept
    {
        private int id;
        private string name;
        private int salary;

        public int  Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class emploinfo
    {
        static void Main(string[] args)
        {
            employee85 e = new employee85();
            e.Id = 101;
            e.Name = "ajay";
            e.Salary = 85000;
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Salary);

        }
    }
    interface IEmpoloyee//interface example=achieved multiple inheritance functionality
    {

        void show();

    }
    interface akshay
    {
        void greet();
    }
    class partrtimeemployee : IEmpoloyee, akshay
    {
        public void show()
        {
            Console.WriteLine("this is method of IEmpoloyee interface");
        }
        public void greet()
        {
            Console.WriteLine("i am akshay");
        }
    }
    class pro
    {
        static void Main(string[] args)
        {
            partrtimeemployee p = new partrtimeemployee();
            p.show();
            p.greet();
        }

    }
    class Principal// HERARCHIECAL INHERITENCE
    {
        public void Monitor()
        {
            Console.WriteLine("Monitor");
        }
    }
    class Teacher : Principal
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
    class Student : Principal
    {
        public void Learn()
        {
            Console.WriteLine("Learn");
        }
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            Principal g = new Principal();
            g.Monitor();
            Teacher d = new Teacher();
            d.Monitor();
            d.Teach();
            Student s = new Student();
            s.Monitor();
            s.Learn();
            Console.ReadKey();
        }



        //class Principal// multilevel INHERITENCE
        //{
        //    public void Monitor()
        //    {
        //        Console.WriteLine("Monitor");
        //    }
        //}
        //class Teacher : Principal
        //{
        //    public void Teach()
        //    {
        //        Console.WriteLine("Teach");
        //    }
        //}
        //class Student : Teacher
        //{
        //    public void Learn()
        //    {
        //        Console.WriteLine("Learn");
        //    }
        //}
        //class MyClass
        //{
        //    static void Main(string[] args)
        //    {
        //        Principal g = new Principal();
        //        g.Monitor();
        //        Teacher d = new Teacher();
        //        d.Monitor();
        //        d.Teach();
        //        Student s = new Student();
        //        s.Monitor();
        //        s.Learn();
        //        Console.ReadKey();
        //    }
        //}

    }
    class GradFater
    {

        public void land()
        {
            Console.WriteLine("GradFater's land");
        }

    }

    class Father : GradFater
    {

        public void home()
        {
            Console.WriteLine("Father's home");
        }

        public void Car()
        {
            Console.WriteLine("Father's Car");
        }
    }

    // Inherit /derived / extends
    class Son : Father
    {

        // son constructor
        public Son()
        {
            Console.WriteLine("Son...");
        }

        public void mobile()
        {
            Console.WriteLine("Son's mobile");
        }
    }

    class Daughter : Father
    {

        // Daughter constructor
        public Daughter()
        {
            Console.WriteLine("Daughter...");
        }

        public void purse()
        {
            Console.WriteLine("Daughter's purse");
        }
    }

    /*
     * Test hybrid inheritance
     */
    public class TestHybridInheritance
    {

        public static void Main(String[] args)
        {

            // Son object
            Son s = new Son();
            s.land();// Grand father method
            s.Car(); // Father method
            s.home();// Father method
            s.mobile();// son method

            // Daughter object
            Daughter d = new Daughter();
            d.land();// Grand father method
            d.Car(); // Father method
            d.home();// Father method
            d.purse();// son method

        }
    }

}





