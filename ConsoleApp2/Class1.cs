using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class strdemo
    {
        static void Main(string[] args)
        {
            string str = "HEllo C#";//keyword
            string s = "Hello DotNet";//literal
            string s1 = new string("Hello My programming");
            int l = s1.Length;
            Console.WriteLine("Length:" + l);

            string str1 = "Hello";
            string str2 = "Hello";
            //Console.WriteLine(str1==str2);
            //str1=str1+ str2;
            //Console.WriteLine(str1==str2);
            //Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
            //Console.WriteLine(str1=str2);
            //str1 = str1 + "c#";
            //Console.WriteLine(str1);
            //Console.WriteLine(str1==str2);
            //Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
            string st = string.Concat(str1, "Pune");
            Console.WriteLine(st + " " + str1);

            int x = s1.IndexOf('r');
            Console.WriteLine(x);

            int y = s1.LastIndexOf('r');
            Console.WriteLine(y);

            string s3 = s1.Substring(4);
            Console.WriteLine(s3);

            string s4 = s1.Substring(4, 7);
            Console.WriteLine(s4);

            string mystring = "java,c#,c++,python";
            string[] s5 = mystring.Split(",");
            foreach (string ss in s5)
            {
                Console.WriteLine(ss);
            }

            Console.WriteLine(string.Join(" ", "pune", " ", "Welcome"));

            string s6 = "     pune    ";
            Console.WriteLine(s6);
            Console.WriteLine(s6.Trim());

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            Console.WriteLine(s1[10]);

        }
    }
    class methodstring
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string str1 = new string("hello");
            Console.WriteLine(str == str1);
            Console.WriteLine(str.Equals(str1));

            int i = str.CompareTo(str1);
            Console.WriteLine(i);
        }
    }
    class reversestring//string convert char array reverse the string
    {
        static void Main(string[] args)
        {
            string str = "India is my Country";
            char[] ch = str.ToCharArray();
            int j = ch.Length - 1;
            for (int i = 0; i < ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            Console.WriteLine(String.Join(" ", ch));
            string st = new string(ch);
            Console.WriteLine(st);
        }
    }
    class reversestr
    {
        static void Main(string[] args)
        {
            string str = "India is my Country";
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
        }
    }
    class reverseword1
    {
        static void Main(string[] args)
        {
            string str = "c# is easy";
            string[] str1 = str.Split(" ");
            string reverse = "";
            for (int i = 0; i < str1.Length; i++)
            {
                string word = str1[i];
                string myword = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    myword = myword + word[j];
                }
                reverse = reverse + myword + " ";
            }
            Console.WriteLine(reverse);

        }
    }
    class countword
    {
        static void Main(string[] args)
        {
            string str;
            int count = 1, length = 0;
            Console.WriteLine("enter a string");
            str = Console.ReadLine();
            while (length <= str.Length - 1)
            {
                if (str[length] == ' ' || str[length] == '\n' || str[length] == '\t')
                {
                    count++;
                }
                length++;
            }
            Console.WriteLine(count);
        }
    }
    //class strbuild
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "HELLO";
    //        StringBuilder sb = new StringBuilder(str);
    //        sb.Append("PUNE");
    //        Console.WriteLine(sb);
    //    }
    //}
    class sb1
    {
        static void Main(string[] args)
        {
            string s = "Pune";
            StringBuilder sb = new StringBuilder(s);
            sb.AppendLine("City");
            Console.WriteLine(sb);
            sb.AppendLine(" for Fun");
            Console.WriteLine(sb);

            sb.Insert(6, "c#");
            Console.WriteLine(sb);
            sb.Remove(2, 6);
            Console.WriteLine(sb);
            //string s = "pune";
            //StringBuilder sb = new StringBuilder(s);
            //Console.WriteLine(sb);

            //StringBuilder sb2 = new StringBuilder("pune");
            //Console.WriteLine(sb2);

            //Console.WriteLine(sb.Equals(sb2));
            //Console.WriteLine(sb == sb2);






        }
    }
    class palstring
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Array.Reverse(a);
            string str_reverse = new string(a);
            if (str.Equals(str_reverse))
            {
                Console.WriteLine(str + "=it is pallendrom string");
            }
            else
            {
                Console.WriteLine(str + "=it is not pallendrom string");
            }
        }
    }
    class patternword
    {
        static void Main(string[] args)
        {
            string str = "I like India country";
            string[] s = str.Split(" ");
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j] + " ");
                }
                Console.WriteLine();

            }

        }

    }
    class strpattern
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            char[] a = str.ToCharArray();

            for (int i = 0; i <= a.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(str[j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
    public interface Imoveable
    {
        static int x;
        void show();
    }
    class car: Imoveable
    {
        public void show()
        {
          Imoveable.x=400;
            Console.WriteLine("My interface method" + Imoveable.x);
        }
    }
    class interfacedemo
    {
        static void Main(string[] args)
        {
            Imoveable m = new car();
                m.show();
        }
    }


}


   
   

