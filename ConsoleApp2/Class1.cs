using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Text;


namespace ConsoleApp2
{
    public class invalidbinerynumber : Exception //exple 10
    {
        public invalidbinerynumber(string s) : base(s)
        {

        }
    }
    class binery
    {
        static void IsBinaryOrNot(int number)
        {
            bool isBinary = true;

            int copy = number;

            while (copy != 0)
            {
                int temp = copy % 10;

                if (temp > 1)
                {
                    isBinary = false;
                    break;
                }
                else
                {
                    copy = copy / 10;
                }
            }

            if (isBinary)
            {
                Console.WriteLine(" is a binary number");
            }
            else
            {
                throw new invalidbinerynumber("not binery number");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                IsBinaryOrNot(1111);
            }
            catch (invalidbinerynumber e)
            {
                Console.WriteLine(e);
            }


        }
    }
    class imeino //exp1
    {

        
        static int sumDig(int n)
        {
            int a = 0;
            while (n > 0)
            {
                a = a + n % 10;
                n = n / 10;
            }

            return a;
        }

        static Boolean isValidIMEI(long n)
        {

            // Converting the number into
            // String for finding length
            String s = n.ToString();
            int len = s.Length;

            if (len != 15)
                return false;

            int sum = 0;
            for (int i = len; i >= 1; i--)
            {
                int d = (int)(n % 10);

                // Doubling every alternate
                // digit
                if (i % 2 == 0)
                    d = 2 * d;

                // Finding sum of the digits
                sum += sumDig(d);
                n = n / 10;
            }

            return (sum % 10 == 0);
        }

        // Driver code
        public static void Main()
        {

           
         
            long n = 490154203237518L;

            if (isValidIMEI(n))
                Console.Write("Valid IMEI Code");
            else
                Console.Write("Invalid IMEI Code");

        }
    }
    class Programmerg366//exp2
    {
        static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5] { 5, 15, 25, 30, 47 };


            int[] arr2 = new int[5] { 55, 60, 76, 83, 95 };
         
      
            int[] merged = new int[10];

            for (i = 0, j = 0; i < 5; i++)
            {
                merged[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merged[j++] = arr2[i];
            }
            Console.WriteLine("Elements of merged array = ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
            }
            Console.WriteLine();
        }
    }
    class Pfgrffh //EXP 8
    {
        static void Main(string[] args)
        {
            int shift = 2;
            string output = "";
            Console.Write("Input: ");
            string input = Console.ReadLine();
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < 65 || input[i] > 90)
                    {
                        throw new Exception("Only A-Z supported.");
                    }
                    int shifted = input[i] + shift;
                    if (shifted > 90)
                    {
                        shifted = 65 + shifted - 91;
                    }
                    output = output + (char)shifted;
                }
            }
            Console.WriteLine("Output: " + output);
        }
    }
    class linkedlist//exple6
    {
        static public void Main()
        {
            LinkedList<String> my_list = new LinkedList<String>();
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("after linked list reverse");
            Stack<String> st = new Stack<String>(my_list);
            foreach(string str in st)
            {
                Console.WriteLine(str);
            }

        }


    }
    


    class NDNDDK ///exp5
    {


        static void printReverse(String str)

        {

            

            int i = 0;

            for (i = 0; i < str.Length && str[i] != ' '; i++)

                Console.Write(str[i]);



           

            String word = "";
            for (; i < str.Length; i++)

            {



                if (str[i] != ' ')

                    word += str[i];
                else

                {

                    word = reverse(word);

                    Console.Write(new StringBuilder(word).ToString() + " ");

                    word = "";

                }

            }
            Console.Write(word + " ");

        }
        static String reverse(String input)
        {

            char[] temparray = input.ToCharArray();

            int left, right = 0;

            right = temparray.Length - 1;


            for (left = 0; left < right; left++, right--)

            {

              

                char temp = temparray[left];

                temparray[left] = temparray[right];

                temparray[right] = temp;

            }

            return String.Join("", temparray);

        }
        public static void Main(String[] args)

        {

           
           string str=Console.ReadLine();

            printReverse(str);

        }
    }
    class altermerdg4 //exp4
    {
        static void alternateMerge(int[] arr1, int[] arr2,
                              int n1, int n2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;


            while (i < n1 && j < n2)
            {
                arr3[k++] = arr1[i++];
                arr3[k++] = arr2[j++];
            }


            while (i < n1)
                arr3[k++] = arr1[i++];


            while (j < n2)
                arr3[k++] = arr2[j++];
        }
        public static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int n1 = arr1.Length;

            int[] arr2 = new int[] { 11, 22, 33, 44 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];
            alternateMerge(arr1, arr2, n1, n2, arr3);

            Console.WriteLine("Array after merging");
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
        }

    }
    class mobilefreq //exp7
    {

       
        static int frequencyDigits(long n,
                                   int d)
        {
            
           int c = 0;
            while (n > 0)
            {


                if (n % 10 == d)
                    c++;

                n = n / 10;
            }
            return c;
        }
        static public void Main(String[] args)
        {

            long N = 8975014275;
            int D = 7;
            Console.WriteLine(frequencyDigits(N, D));
        }
    }
    class ENCODE //EX8

    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string nm=Console.ReadLine();
            int step = 2;
            int newchar = 0;
            foreach(char ch in nm)
            {
                newchar = ch + step;
                if(newchar>90)
                {
                    newchar = newchar - 26;
                }
                else if(char.IsDigit(ch))
                {
                    newchar = ch;
                    newchar++;
                }
                Console.Write((char)newchar);

            }
        }
    }
    class pattern9
    {
        static void Main(string[] args)
        {
            int k = 5;
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i%2==1)
                    {
                        Console.Write(j);
                    }
                    else
                        Console.Write((char)(64+j));
                }
                Console.WriteLine();
            }
            for(int i=2;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(j);
                    }
                    else
                        Console.Write((char)(64 + j));

                }
                Console.WriteLine();
            }
        }
    }
    class demo17
    {
        static void Main(string[] args)
        {
         LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(4);
            l1.AddLast(5);
            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(11);
            l2.AddLast(12);
            l2.AddLast(13);
            l2.AddLast(14);
            l2.AddLast(15);
          l2.AddLast(16);
            LinkedList<int> l3 = new LinkedList<int>();
            int i = 0;
            int k = 0;
            while(l3.Count<l1.Count+l2.Count)
            {
                if(k<l1.Count && k<l2.Count)
                {
                    l3.AddLast(l1.ElementAt(k));
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                else if(k<l1.Count)
                {
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                else
                {
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                i++;
            }
            foreach(int d in l1)
                Console.Write(d+" ");
            Console.WriteLine("-----------------------------");

            foreach (int d in l2)
                Console.Write(d + " ");
            Console.WriteLine("-----------------------------");

            foreach (int d in l3)
                Console.Write(d + " ");
            Console.WriteLine("-----------------------------");
        }
    }
    public class CheckDuckNo
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            String strNo = number.ToString();
            int l = strNo.Length;
            int ctr = 0;
            char chr;
            for (int i = 1; i < l; i++)
            {
                chr = strNo[i];
                if (chr == '0')
                {
                    ctr++;
                    break;
                }
            }
            char f = strNo[0];
            if (ctr > 0 && (f == '0' || f != '0'))
                Console.Write("Duck No.");
            else
                Console.Write("Not a duck No.");


        }
    }
    class weired
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 2 != 0)
            {
                Console.WriteLine("weird");
            }
            else if (input >= 2 && input <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (input >= 6 && input <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (input > 20)
                Console.WriteLine("Not Weird");
        }
    }



}















