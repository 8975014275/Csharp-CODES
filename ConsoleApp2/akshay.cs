using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FIOBOTECH
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i <= 10; i++)
            {
                c = a + b;
                Console.WriteLine(a + " ");
                a = b;
                b = c;
            }
        }
    }
    class fibonnacci
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }

        }
    }
    class upperlower
    {
        static void Main(string[] args)
        {
            string newstr = "";
            Console.WriteLine("enterrt the string");
            string str=Console.ReadLine();
            for(int i=0;i<str.Length;i++)
            {
                char ch = str[i];
                if(ch>='A' && ch<='Z')
                {
                    ch = (char)(ch + 32);
                   
                }
                else if(ch>='a' && ch<='z')
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);

        }
        
    }
    class primenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
          int  count = 0;
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("prime");
            }
            else
                Console.WriteLine("not prime");

        }
    }
    class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact= fact*i;
              
            }
            Console.WriteLine(fact);

        }
    }
    internal class palandrop12
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
    class armstrongnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int a = num;
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                int cube = digit * digit * digit;
                sum = sum + cube;
                num = num / 10;


               
               
            }
            if(sum==a)
            {
                Console.WriteLine("armstrong");
            }
            else
                Console.WriteLine("not armstrong");


        }
    }
    class fizzbux
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("buzz");
                }
                else
                    Console.WriteLine(i);

            }

        }
    }
    class duplica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str=Console.ReadLine();
            string result = "";
            for(int i=0;i<str.Length;i++)
            {
                if(!result.Contains(str[i]))
                {
                    result = result + str[i];

                }
                
            }
            Console.WriteLine(result);

        }
    }
    class anagramdhdh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the string");
            string str2=Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str1.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string valu1 = new string(ch1);
            string valu2 = new string(ch2);
            if(valu1==valu2)
            {
                Console.WriteLine("anagram");
            }
            else
                Console.WriteLine("not anagram");
        }
    }
    class minmaxarar
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("eneter the leement");
            for(int i=0;i<a.Length;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            int max=a[0];
            int min=a[1];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min=a[i];
                }
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);



        }
    }
    class primearray
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            Console.WriteLine("enter the element");
            for(int i=0;i<b.Length;i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                int n = b[i];
                bool isprime = true;
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        isprime = false;
                        break;

                    }
                }
                if(isprime==true)
                {
                    Console.WriteLine(b[i]);
                }
            }
        }
    }
    class searcharray1
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            Console.WriteLine("enter the element");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("eneter tehe numbetr");
            int num=int.Parse(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i]==num)
                {
                    ispresent = true;
                }
            }
            if(ispresent==true)
            {
                Console.WriteLine("present");
            }
            else
                Console.WriteLine("not present");



        }
    }
    class sortingarary
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];
            Console.WriteLine("enter the element");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                for(int j=i+1;j<b.Length;j++)
                {
                    if (b[i] > b[j])
                    {
                        int temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;

                    }
                }
            }
            Console.WriteLine("after the sort");
            Console.WriteLine(string.Join(" ",b));

        }
    }
    class frequency
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {

                            count++;
                        }
                       

                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }


                    // Console.WriteLine(a[i] + " " + count);
                }
            }
        }
    }





}
   
  



   
   

