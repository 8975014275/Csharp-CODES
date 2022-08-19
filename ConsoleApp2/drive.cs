using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class baseclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Array.Reverse(a);
            string reverse=new string(a);
            Console.WriteLine(reverse);
            if(reverse==str)
            {
                Console.WriteLine("paLLENDROM");
            }
            //string revstr = "";
            //for (int i=str.Length-1;i>=0;i--)
            //{
            //    revstr = revstr + str[i];
            //}
            //Console.WriteLine(revstr);
            //if(revstr==str)
            //{
            //    Console.WriteLine("pallendrom string");
            //}
            //else
            //    Console.WriteLine("not pallendrom");
        } //  select departname,sum(salary) as total from employee from groupby departname;
    }
    class anagram3636
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter trhe string");
            string str1=Console.ReadLine();
            Console.WriteLine("enter trhe string");
            string str2 = Console.ReadLine();
            char[]ch1=str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1=new string(ch1);
            string val2=new string(ch2);
            if(val1==val2)
            {
                Console.WriteLine("anagram");
            } 
            else
            {
                Console.WriteLine("not anagram");
            }


        }
    }
    class dgdhdvb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i=0;i<str.Length;i+=2)
            {
                newstr = newstr + str[i];
                
            }
            Console.WriteLine(newstr);
        }
    }

    


     

   

}
