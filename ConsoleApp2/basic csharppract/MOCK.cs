using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class palandrop
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine()); ;
            int n = a;
            int rev = 0;
            while (a > 0)
            {
                int d = a % 10;
                rev = rev * 10 + d;
                a = a / 10;
            }
            if (rev == n)
                Console.WriteLine("pallendrom");
            else
                Console.WriteLine("not pallendrom");
        }
    }
    class dgs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int digit;
          int sum = 0;
            int cube;
            
            while(num>0)
            {
                digit = num % 10;
                cube = digit * digit * digit;
                num= num / 10;
                sum = sum * digit;




            }
            if(sum==num)
            {
                Console.WriteLine("armstrong number");

            }
            else
                Console.WriteLine("not armstrong");
           
        }
    }
    class digitsum
    {
        static void Main(string[] args)
        {
            int num = 126835;
            int sum = 0;
            int remainder;
            

            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10;
                if (remainder % 2 == 1)
                {
                    
                    sum = sum + remainder;

                }

            }

            Console.WriteLine(sum);

        }
    }
    class reversenum
    {
        static void Main(string[] args)
        {
            int number = 123;
            int remainder, reversenum = 0;
            while(number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                reversenum = reversenum * 10 + remainder;
            }
            Console.WriteLine("reverse number is:"+ reversenum);
        }
    }
    class oddeven
    {
        static void Main(string[] args)
        {
            int number, remainder;
            Console.WriteLine("enter the number");
            number=int.Parse(Console.ReadLine());
            remainder=number % 2;
            if(remainder == 0)
            {
                Console.WriteLine("even number");
            }
            else
                Console.WriteLine("odd number");
        }
    }
    class proprime
    {
        static void Main(string[] args)
        {
            int number, count = 0;
            Console.WriteLine("enter the number");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=number; i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("not prime number");
            }
            
        }
    }
    class fibo
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i <= 20; i++)
            {
                c = a + b;
                Console.Write(c);
                a=b;
                b = c;
            }
        }
    }
    class rever
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 90, 45, 29, 37, 78 };
            int length = arr.Length - 1;
            string strReverse = null;
            while(length >= 0)
            {
                strReverse=strReverse+ arr[length];
                length--;

            }
            Console.WriteLine( );
            Console.WriteLine(" "+strReverse);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int length = arr.Length - 1;
            string strReverse = null;
            while (length >= 0)
            {
                strReverse = strReverse + arr[length];
                length--;
            }
            Console.WriteLine();
            Console.WriteLine("Reverse Array is " + " " + strReverse);
            Console.ReadLine();
        }
    }
    class Programmerg
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            arr1 = arr1.Concat(arr2).ToArray();
            foreach (var e in arr1)
            {
                Console.WriteLine(e);
            }
        }
    }
    class swap//without temp variable
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("before swap");
            Console.WriteLine("Num1={0} Num2", num1, num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("after swap");
            Console.WriteLine("Num1={0} Num2={1}", num1, num2);
        }
    }
    class swapi//using temp
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("before num1={0},num2={1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after num1={0},num2={1}", num1, num2);




        }
    }
    class anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort((ch2));
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("string are anagram");

            }
            else
                Console.WriteLine("string are not anagram");
        }
    }
    class Myrefil
    {
        private string color;
        private int length;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
    }
    class Mynib
    {
        private string nib_material;
        private int width;

        public string NibMaterial
        {
            get { return nib_material; }
            set { nib_material = value; }

        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Mypen
    {
        private string brand_name;
        private int caplength;
        Myrefil refil;
        Mynib nib;

        public string Brand_name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public Myrefil Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public Mynib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        static void Main(string[] args)
        {
            Mypen p = new Mypen();
            p.Brand_name = "REYNOLDS";
            p.Caplength = 5;
            p.Refil = new Myrefil();
            p.Refil.Color = "BLUE";
            p.Refil.Length = 4;

            p.Nib = new Mynib();
            p.Nib.NibMaterial = "GOLD ALLOY";
            p.Nib.Width = 1;

            Console.WriteLine(p.Brand_name + " " + p.Caplength + " " + p.Refil.Color + " " + p.Refil.Length + " " + p.Nib.NibMaterial + " " + p.Nib.Width);




        }
    }


    class prsumstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();

            double sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum=" + sum);
        }
    }
    class pr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();

            double sum = 0;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    count++;
                    sum = sum + x;
                }
            }
            Console.WriteLine("average=" + (sum / count));
        }
    }
    class strsummethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum=" + sum);
        }

    }
    class charstrring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
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
    class charstrmethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    ch = (char)(ch + 32);
                }
                else if (char.IsLower(ch))
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
        }
    }
}
  


    

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                