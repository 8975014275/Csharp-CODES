using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 't', 'u', 'd', 'n' };
            Console.WriteLine(String.Join(" ", ch));
            Console.WriteLine();
            Console.WriteLine("////////////////");
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.Write(ch[i] + " ");
            }
        }
    }
    //class program1
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("enter the array size");
    //        int num=int.Parse(Console.ReadLine());
    //        int[]number=new int[num];

    //        for(int i=0;i<num;i++)
    //        {
    //            Console.WriteLine("enter the data");
    //            int data = int.Parse(Console.ReadLine());
    //                number[i] = data;

                
    //        }
    //        Console.WriteLine("......your data.....");
    //        Console.WriteLine(String.Join(" ",number));
    //    }
    //}
    class Reverse
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 't', 'u', 'd', 'n' };
            Console.WriteLine(String.Join(" ", ch));
            Console.WriteLine();
            Console.WriteLine("////////////////");
            int j = ch.Length - 1;
            for (int i = 0; i <= ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;

            }
            Console.WriteLine(String.Join(" ", ch));

        }
    }
    class arrayswapi//Hw
    {
        static void Main(string[] args)
        {
            int[] sw = { 3, 8, 5, 6, 7 };
            Console.WriteLine(String.Join(" ", sw));
            Console.WriteLine();
            Console.WriteLine("//////////////");
            int j = sw.Length - 1;
            for (int i = 0; i <= sw.Length / 2; i++)
            {
                int temp = sw[i];
                sw[i] = sw[j];
                sw[j] = temp;
                j--;
            }
            Console.WriteLine(String.Join(" ", sw));
        }
    }
    class maxelement
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 3, 1, 8, 2 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("max=" + max);

        }
    }
    class ascdsc
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the original array is");
            for(int i=0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            int temp;
            for(int i=0; i < a.Length; i++)
            {
               for(int j=0;j<a.Length;j++)
                {
                    if (j<a.Length/2)
                    {
                        if (a[i] > a[j])
                        {
                             temp = a[i];
                            a[i]= a[j];
                            a[j]= temp;
                        }
                    }
                    else
                    {
                        if (a[i] < a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("array after discending half");
            Console.WriteLine(String.Join(" ",a));
          


        }
    }
    class minimumelement//minimum HW
    {
        static void Main(string[] args)
        {
            int[] b = { 95, 90, 67, 85, 89 };
            int min = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < min)
                {
                    min = b[i];
                }
            }
            Console.WriteLine("min" + min);
        }
    }
    class abxc
    {
        static void Main(string[] args)
        {
            int[] c = new int[5];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ",c));
            for(int i = 0; i < c.Length; i++)
            {
                for(int j=i+1;j<c.Length;j++)
                {
                    if (c[i] > c[j])
                    {
                        int temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                   
                    

                }
               


            }
            Console.WriteLine("ascending order");
            Console.WriteLine(String.Join(" ", c));

        }
    }
    class Occurence
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 2, 2, 2, 9, 2, 8, 5, 5 };
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
                  /*  if (count >1) *//*.........SHOW ONLY OCC AS PER WISH THAN 1*/
                        Console.WriteLine(a[i] + " " + count);
                }
            }
        }
    }
    class occe3
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 5, 10, 2, 5, 4, 5 };
            var dict=new Dictionary<int, int>();
            foreach(var value in a)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }
            foreach(var pair in dict)
            {
                Console.WriteLine("{0} ={1} time(s)", pair.Key, pair.Value) ;
            }
        }
    }

    class Searcharray
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 4, 2, 9, 1 };
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("enter the number for searched");
            int num =Convert.ToInt32(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("not present");
            }
        }
    }
    abstract class Animal
    {
       public int x = 100;
        public static int y = 500;

        public Animal(string name)
        {
            Console.WriteLine("Animal Constructor"+" "+name);
        }

        public abstract void show();

        public void Myanimal()
        {
            Console.WriteLine("MY ANIMAL");
        }
    }
    class Dog: Animal
    {
        public Dog():base("Rocky")
        {
            Console.WriteLine("Dog Constructor");
        }
        public override void show()
        {
            Console.WriteLine("Dog"+" "+x+" "+y);
        }

    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.show();
            a.Myanimal();

        }
    }
    class digitsum1
    {
        static void Main(string[] args)
        {
            int num = 126835;
            int sum = 0;
            int remainder;
            int count = 0;


            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10;
                if (remainder % 2 == 0)
                {
                    count++;

                    sum = sum + remainder;

                }

            }

            Console.WriteLine(sum/count);

        }
    }
    class minmax
    {
        static void Main(string[] args)
        {
            int[] c = new int[6];
            Console.WriteLine("enter the array element");

            for (int i=0;i<c.Length;i++)
            {
               

                c[i] = int.Parse(Console.ReadLine());
            }
            int min = c[0];
            int max = c[0];
            for(int i=0;i<c.Length;i++)
            {
                if (min > c[i])
                {
                    min= c[i];
                }
                if(max< c[i])
                {
                    max= c[i];
                }
            }
            Console.WriteLine("minimum number is:"+min);
            Console.WriteLine("maximum number:"+max);
        }
    }
    class ana
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string");
            string str1=Console.ReadLine();
            Console.WriteLine("enter string2");
            string str2=Console.ReadLine();
            char[]ch1=str1.ToLower().ToCharArray();
            char[]ch2=str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if(val1 == val2)
            {
                Console.WriteLine("string are anagram");

            }
            else
                Console.WriteLine("string are not anagram");
        }
    }
    class pat

    {
        static void Main(string[] args)
        {
            
       
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
  
    class series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the terms");
            int terms=int.Parse(Console.ReadLine());
            int sum = 1;
            for(int i=1;i<terms;i++)
            {
                sum = (i * i) + (i * i * i);
                Console.WriteLine(sum);
            }
        }
    }
  
 
   
}
   
    

    














