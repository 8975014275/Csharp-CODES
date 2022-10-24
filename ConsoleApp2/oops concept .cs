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
    class person//STATIC CONSTRUCTOR
    {
        public static string personname;
        public static int personage;
        public int num;
        static person()
        {
            personname = "akshay";
            personage = 21;

            Console.WriteLine("static constructor invokes!");
        }

        public person()
        {
            num = 10;

            Console.WriteLine("default constructor invokes=" + num);
        }
        public person(int a)
        {


            Console.WriteLine("default constructor invokes=" + a);
        }

        public void Getdetails()
        {
            Console.WriteLine("person name:" + personname);
            Console.WriteLine("person age:" + personage);
        }

    }
    class Program1
    {
        static void Main(string[] args)
        {
            person P = new person();
            P.Getdetails();
            person c = new person(89);
            // person q=new person();static constructor called once time only and default called as per object

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
    class Baseclass//CONSTRUCTOR IN INHERITANCE
    {
        public Baseclass(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Derrivedclass : Baseclass
    {
        public Derrivedclass() : base("HELLO AKSHAY")
        {
            Console.WriteLine("this is constructor of derrived class");
        }
    }
    class pract
    {
        static void Main(string[] args)
        {
            Derrivedclass m = new Derrivedclass();
        }
    }
    static class product1//...static class concept
    {
        public static int productid;
        public static string productname;
        public static int productprice;

        static product1()
        {
            productid = 111;
            productname = "table";
            productprice = 2500;

        }
        public static void getdetatils()
        {
            Console.WriteLine("productid:" + productid);
            Console.WriteLine("productname:" + productname);
            Console.WriteLine("productprice:" + productprice);

        }
        public static void getdiscount()
        {
            int d_amount = productprice / 10;
            Console.WriteLine("discount amount:" + d_amount);
            Console.WriteLine("totalcost:" + (productprice - d_amount));
        }

    }
    class prog
    {
        static void Main(string[] args)
        {
            product1.getdetatils();
            product1.getdiscount();
        }
    }
    class student//static keyword concept
    {
        public int rollno;
        public string firstname;
        public string lastname;
        public int standard;
        public static string schoolname = "DATTA VIDYALAYA";
        public static int fees = 4000;

        public void printfullname()
        {
            string fullname = this.firstname + " " + this.lastname;
            Console.WriteLine("your full name {0}", fullname);
        }
        public static int getfees()
        {
            return fees;
        }
        public static int getfeesannualincrement(int fee)
        {
            return fee / 10;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            student a = new student();
            a.rollno = 23;
            a.firstname = "akshay";
            a.lastname = "giri";
            a.standard = 5;
            student b = new student();
            b.rollno = 25;
            b.firstname = "vivek";
            b.lastname = "giri";
            b.standard = 6;
            Console.WriteLine(a.rollno);
            Console.WriteLine(a.firstname);
            Console.WriteLine(a.lastname);
            Console.WriteLine(a.standard);
            a.printfullname();
            Console.WriteLine(student.schoolname);
            Console.WriteLine(student.getfees());
            Console.WriteLine("///////////");
            Console.WriteLine(b.rollno);
            Console.WriteLine(b.firstname);
            Console.WriteLine(b.lastname);
            Console.WriteLine(b.standard);
            b.printfullname();
            Console.WriteLine(student.schoolname);
            Console.WriteLine(student.getfees());
            Console.WriteLine(student.getfeesannualincrement(3000));
        }
    }


}





