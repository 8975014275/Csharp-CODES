using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
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
            Console.WriteLine("productid:"+productid);
            Console.WriteLine("productname:"+ productname);
            Console.WriteLine("productprice:"+ productprice);

        }
        public static void getdiscount()
        {
            int d_amount = productprice / 10;
            Console.WriteLine("discount amount:" + d_amount);
            Console.WriteLine("totalcost:"+(productprice-d_amount));
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
            string fullname=this.firstname+" "+this.lastname;
            Console.WriteLine("your full name {0}",fullname);
        }
        public static int getfees()
        {
            return fees;
        }
        public static int getfeesannualincrement(int fee)
        {
            return fee/10;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
         student a=new student();
            a.rollno = 23;
            a.firstname = "akshay";
            a.lastname = "giri";
            a.standard = 5;
            student b=new student();
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
           
            Console.WriteLine("default constructor invokes="+num);
        }
        public person(int a)
        {
            

            Console.WriteLine("default constructor invokes=" + a);
        }
        
        public void Getdetails()
        {
            Console.WriteLine("person name:"+personname);
            Console.WriteLine("person age:"+personage);
        }
       
    }
    class Program1
    {
        static void Main(string[] args)
        {
            person P=new person();
            person c = new person(89);
            // person q=new person();static constructor called once time only and default called as per object

        }
    }
    class eec//call by vallue
    {
        public void m1(int value)
        {
            value = value + 10;
            Console.WriteLine("value in the call function:" + value);
        }
        public static void Main(string[] args)
        {
            int value = 15;
            eec p=new eec();
            Console.WriteLine("value before calling the method:"+value);
            p.m1(value);
            Console.WriteLine("value after calling function:"+value);
        }
    }
    class eec1//call by refferance
    {
        public void m1( ref int value)
        {
            value = value + 10;
            Console.WriteLine("value in the call function:" + value);
        }
        public static void Main(string[] args)
        {
            int value = 15;
            eec1 p = new eec1();
            Console.WriteLine("value before calling the method:" + value);
            p.m1(ref value);
            Console.WriteLine("value after calling function:" + value);
        }
    }
    class eec2//out parameter alternate
    {
        public void m1(out int i)
        {
            i = 5;
            i=i+ 10;
        }
        public static void Main(string[] args)
        {
            int i;
            eec2 s=new eec2();
            //Console.WriteLine("before calling function:"+i);
            s.m1(out i);
            Console.WriteLine("after calling function:"+i);
        }
    }
    class pr1
    {
        public static void m1(out int a)
        {
            a = 20;
            Console.WriteLine("value is:"+a);
        }
        static void Main(string[] args)
        {
            int value;
            m1(out value);
            Console.WriteLine(value);

        }
    }
    class program1//out parameter
    {
        static void sum(int x,int y,out int z)
        {
            z = x + y;
        }
        static void Main(string[] args)
        {
            int result = 0;
            sum(10, 26,out result);
            Console.WriteLine(result);


        }
    }
    class project//constant keyword
    {
        //public const double PI = 3.14;
        public const string company = "motherson";

        static void Main(string[] args)
        {
           

            Console.WriteLine(company);

        }
    }
    public class handling//exception handling
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = int.Parse(Console.ReadLine());
            int result = 0;
            try
            { 
                 result = i / j;
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine("testing");
            }
            catch (Exception e)
            {
                Console.WriteLine("devideby zero not allowed");
            }
            finally
            {
                Console.WriteLine("finally block");
            }
            Console.WriteLine("Result is:"+result);
           

        }
    }
    class throwcustom1// our throw our catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the age");
            int age = int.Parse(Console.ReadLine()); 
            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("you are eligible to vote");
                }
                else
                {
                    throw new Exception("you are not eligible to vote");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
    public class notvalidedge:Exception//custom exception 
    {
        public notvalidedge(string s):base(s)
        {
            
        }
    }
    class cee
    {
        static void checkage(int i)
        {
            if(i<18)
            {
                throw new notvalidedge("age is not valid");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                checkage(16);
            }
            catch(notvalidedge ne)
            {
                Console.WriteLine(ne);
            }
        }

    }

    class error3
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = 5;
            int x,y;
            try
            {
                x = a / (b - c);
            }
            catch (Exception e)
            {
                Console.WriteLine("devide by zero not allow");
            }
            y = a /(b + c);
            Console.WriteLine("y:"+y);

        }

    }
  
    class Baseclass//CONSTRUCTOR IN INHERITANCE
    {
        public Baseclass(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Derrivedclass:Baseclass
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
            Derrivedclass m=new Derrivedclass();
        }
    }
    class pl
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[b];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (b < 6)
            {
                Array.Reverse(arr);
            }


            int size = arr.Length - 1;
            int max = 0;
            int q = 1;
            for (int i = 0; i < size; i++)
            {
                int h = arr[q] - arr[i];
                if (max < h)
                {
                    max = h;
                }
                q++;
            }
            Console.WriteLine(max);
        }
    }
    class PPPP
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num%10==0)
            {
                Console.WriteLine("zero");
            }
            else if(num%15==0)
            {
                Console.WriteLine("five");
            }
            else if(num%9==0)
            {
                Console.WriteLine("odd");
            }
            else if(num%4==0)
            {
                Console.WriteLine("even");
            }
        }
    }
    class qppp
    {
        static void Main(string[] args)
        {
            string str = "";
            int len, vowel, consonent;
            str=Console.ReadLine();
            vowel = 0;
            consonent = 0;
            len = str.Length;
            for(int i=0;i<len;i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i]=='u')
                {
                    vowel++;
                }
                else
                    consonent++;
            }
            Console.WriteLine(vowel);
            Console.WriteLine(consonent);
            int product = vowel * consonent;
            Console.WriteLine(product);
            if(product%2==0)
            {
                Console.WriteLine("verified");
            }
            else
                Console.WriteLine("unverified");
        }
    }

   
  
  

















}
