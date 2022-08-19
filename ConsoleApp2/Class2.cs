using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class s
    {
        static void Main(string[] args)
        {
            //string x = "vivek";
            //x = "giri";
            //Console.WriteLine(x);
            string x = "";
            for(int i = 0; i < 10000; i++)
            {
                x = "shiv" + x;
            }
        }
    }
    class visitcount
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("enter the");
            for(int i = 0; i < a.Length; i++)
            {
                a[i]=int.Parse(Console.ReadLine());

            }
            for(int i = 0; i < a.Length; i++)
            {
                bool isvisited = false;
                int count = 1;

                for(int k=i-1;k>=0;k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;

                        }

                    }
                }
            }
              
        }
    }
    class dgjs
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(i);

                }
            }
        }
    }
       
 
    
  
   
 
   
   
}
