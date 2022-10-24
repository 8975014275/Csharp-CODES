using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public class calculato//method concept
    {
        int num1 = 10;
        int num2 = 20;
        int result;
        void Add()
        {
            result = num1 + num2;
            DisplayResult();

        }
        void Sub()
        {
            result = num1 - num2;
            DisplayResult();

        }
        void Mul()
        {
            result = num1 * num2;
            DisplayResult();

        }
        void Div()
        {
            result = num1 / num2;
            DisplayResult();

        }
        void DisplayResult()
        {
            
            Console.WriteLine(result);

        }
        public static void Main(string[] args)
        {
            calculato c = new calculato();
            c.Add();

        }
    }
    class recure//recursion concept:derrived from recur means repeatation,by virtue ofd its method called itself.
    {             //it must call itself again and again.
                   //method must have exit condition
        int num = 1;
        void counting()
        {
            if(num==11)
            {
                return;//control the course of the program execution.
            }
            Console.WriteLine(num);
            num++;
            counting();
        }
        static void Main(string[] args)
        {
            recure c = new recure();
            c.counting();

        }
    }
    class recfact//fact using recursion
    {
        int num = 5;
        int result = 1;
        int Factorial()
        {
            if(num==0)
            {
                return 1;
            }
            result = result * num;
            num--;
            Factorial();
            return result;
        }
        static void Main(string[] args)
        {
            recfact re=new recfact();
            int fact=re.Factorial();
            Console.WriteLine("factorial is:"+fact);

        }
    }
    class genmethod//GENERIC METHOD
    {
        //public static void ShowArray<T>(T[]arr)
        //{
        //    for (int i = 0; i <arr.Length ; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }

        //}
       public static bool Check<T>(T a,T b)
        {
            bool c=a.Equals(b);
            return c;
        }
    }
    class prom
    {
        static void Main(string[] args)
        {
            Console.WriteLine(genmethod.Check(10,10));
            Console.WriteLine(genmethod.Check("aks","ali"));
            Console.WriteLine(genmethod.Check('a','b'));
            //int[] Number = new int[3];
            //Number[0] = 1;
            //Number[1] = 2;
            //Number[2] = 3;

            //string[] Names = { "aksh", "ara", "sam" };
            //genmethod.ShowArray(Number);
            //genmethod.ShowArray(Names);

        }
       

    }
    class genclass<T>
    {
        T box;
        public genclass(T b)
        {
            this.box = b;
        }
        public T getbox()
        {
            return this.box;
        }
    }
    class genprclass
    {
        static void Main(string[] args)
        {
            genclass<int> ge = new genclass<int>(6);
            genclass<string> ge1= new genclass<string>("aksh");
            Console.WriteLine(ge.getbox());
            Console.WriteLine(ge1.getbox());


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
    //indexer concept important topic
    class indexconn
    {
       private int[] age = new int[3];
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < age.Length)
                {
                    if (value > 0)
                    {
                        age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("value is invalid");
                    }
                }
                else
                {
                    Console.WriteLine("invalid index");
                }
            }
            get
            {
                return age[index];
            }
          
        }

    }
    class indexercon
    {
        static void Main(string[] args)
        {
            indexconn e=new indexconn();
            e[2] = 9;
            Console.WriteLine(e[2]);

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

    enum Days//Enamuration
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
    }
    class sdg
    {
        static void Main(string[] args)
        {

            // Days myday = (Days)1;  explicit conversion
            //int mday=(int)Days.friday; implicit conversion
            Days birthday = Days.sunday;
            Console.WriteLine(birthday);
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
    //Dependancy injection using constructor
    //interface IAccount
    //{
    //    void PrintDetais();

    //}
    //class CurrentAccount: IAccount
    //{
    //    public void PrintDetais()
    //    {
    //        Console.WriteLine("details of current account");

    //    }

    //}
    //class SavingAccount : IAccount
    //{
    //    public void PrintDetais()
    //    {
    //        Console.WriteLine("details of saving account");

    //    }
    //}
    //class Account
    //{
    //    private IAccount account;
    //    public Account(IAccount account)//parameterized constructor.
    //    {
    //        this.account = account;
    //    }
    //    public void PrintAccount()
    //    {
    //        account.PrintDetais();

    //    }
    //}
    //class programdi
    //{
    //    static void Main(string[] args)
    //    {
    //        IAccount CA=new CurrentAccount();
    //        Account a=new Account(CA);
    //        a.PrintAccount();

    //        IAccount sa = new SavingAccount();
    //        Account a2 = new Account(sa);
    //        a2.PrintAccount();


    //    }
    //}

    ////propertry injection

    //public  interface IAccount
    //{
    //    void PrintDetais();

    //}
    //class CurrentAccount : IAccount
    //{
    //    public void PrintDetais()
    //    {
    //        Console.WriteLine("details of current account");

    //    }

    //}
    //class SavingAccount : IAccount
    //{
    //    public void PrintDetais()
    //    {
    //        Console.WriteLine("details of saving account");

    //    }
    //}
    //class Account
    //{
    //    public IAccount account { get; set; }//using property

    //    public void PrintAccount()
    //    {
    //        account.PrintDetais();

    //    }
    //}
    //class programdi
    //{
    //    static void Main(string[] args)
    //    {
    //        Account sa = new Account();
    //        sa.account=new SavingAccount();
    //        sa.PrintAccount();

    //        Account ca = new Account();
    //        ca.account = new CurrentAccount();
    //        ca.PrintAccount();

    //    }
    //}


    //method injection
    public interface IAccount
    {
        void PrintDetais();

    }
    class CurrentAccount : IAccount
    {
        public void PrintDetais()
        {
            Console.WriteLine("details of current account");

        }

    }
    class SavingAccount : IAccount
    {
        public void PrintDetais()
        {
            Console.WriteLine("details of saving account");

        }
    }
    class Account
    {
       
        public void PrintAccount(IAccount account)
        {
            account.PrintDetais();

        }
    }
    class programdi
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.PrintAccount(new SavingAccount());
          

            Account ca = new Account();
            ca.PrintAccount ( new CurrentAccount());
           

        }
    }






















}
