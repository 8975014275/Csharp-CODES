 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EXCE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter the number");
            try
            {
                int a = int.Parse(Console.ReadLine());
               
            }
            catch(FormatException e)
            {
                Console.WriteLine("input can string");
            }
            
            for(int i=1;i<=10;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class exc1//multiple catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter the number");
            try
            {
              int a=int.Parse(Console.ReadLine());
              int b=int.Parse(Console.ReadLine());
                Console.WriteLine("devision"+a/b);
                Console.WriteLine("try end");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)//...universal handler it should be always last
            {
                Console.WriteLine(e.Message);
            }
           // SystemException s=new IndexOutOfRangeException();
            int[] p = { 1, 2, 3, 4, 5 };
            for(int i=0;i<=p.Length;i+=2)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
    class exc3//nested try block
    {
        static string nm;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter the number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b= int.Parse(Console.ReadLine());
                Console.WriteLine("division:"+a/b);
                try
                {
                    Console.WriteLine("enter the age");
                    int c=int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("try end");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class exc5
    {
        static void m1()
        {
            Console.WriteLine("m1 starts");
            Console.WriteLine("enter the number");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("m1 ends");
        }
        public static void m2()
        {
            m1();
            Console.WriteLine("in m2........");
        }
        static void Main(string[] args)
        {
            try
            {
                m2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("main ends");
        }
    }
    class exc6
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the number");
                int a=int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");//in case error or no error finally block execute
            }

        }
    }
    class exc7
    {

        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("enter the number");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("D://a.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
                if(sr != null)
                    sr.Close();

            }
           
        }
    }
    class InvalidExperienceException:ApplicationException
    {

    }
    class Emp
    {
        string nm;
        int experience;
        public string Nm
        {
            set { this.nm = value; }
            get { return nm; }
        }
        public override string ToString()
        {
            return "Name:" + nm + "Experience" + experience;
        }
        public int Experience
        {
            set
            {
                if (value < 0)
                    throw new InvalidExperienceException();
                else
                    this.experience = value;
            }
            get { return experience; }  
        }
    }
    class exc9
    {
        static void Main(string[] args)
        {
            Emp e=new Emp();
            Console.WriteLine("enter name and experience");
            e.Nm = Console.ReadLine();
            try
            {
                e.Experience = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("experince cant be negative");
            }
            Console.WriteLine(e);


        }
    }
    class pract2//practicing finaly block 
    {
        static void Main(string[] args)
        {
            try
            {
                string a = null;
                Console.WriteLine(a.Length);
                //int a = 10;
                //int b = 5;
                //int c = a / b;
                //Console.WriteLine(c);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally block executed");
            }
        }
    }
    class throwcustom// our throw our catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the age");
            int age=int.Parse(Console.ReadLine());
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
           
           
        }
    }

       
  


}
