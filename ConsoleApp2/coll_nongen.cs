using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class arlist
    { 
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add(12);
            al.Add("omkar");
            al.Add(true);
            al.Add(new StringBuilder("Siya"));
            foreach(object ob in al)
            {
                Console.WriteLine(ob);
            }
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
    //class dhsnsb
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayList ak=new ArrayList();
    //        ak.Add("malkapur");
    //        ak.Add(5);
    //        ak.Add("shegaon");
    //        ak.Add("buldana");
    //        Console.WriteLine("enter the city to delete");
    //       string name = Console.ReadLine();
    //        for(int i=0;i<ak.Count;i++)
    //        {
    //            if (name == ak[i])
    //            {
    //                ak.Remove(name);
    //            }
    //            Console.WriteLine(ak[i]);

    //        }
    //    }
    //}
    class lisstfor
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            a.Add("akshay");
            a.Add("rahul");
            a.Add("bheem");
            a.Add("sachin");
            //  a.Remove("akshay");
            // a.Sort();
            Console.WriteLine("enter the name to remove");
            string name = Console.ReadLine();
            for (int i = 0; i < a.Count; i++)
            {
                if (name == a[i])
                {
                    a.Remove(name);
                    //    i--;

                }
                Console.WriteLine(a[i]);

            }
            //foreach(string s in a)
            //{
            //    Console.WriteLine(s);
            //}



        }

    }
    class arylist
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            Console.WriteLine("adding some number");
            ar.Add(45);
            ar.Add(78);
            ar.Add(33);
            ar.Add(56);
            ar.Add(12);
            ar.Add(23);
            ar.Add(9);
            Console.WriteLine("CAPACITY:"+ar.Capacity);
            Console.WriteLine("count:"+ar.Count);
            foreach(int i in ar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            ar.Sort();
            foreach(int i in ar)
            {
                Console.WriteLine(i);
            }


        }
    }
    class prostack
    {
        static void Main(string[] args)
        {
            Stack myStack=new Stack();
            myStack.Push("Akshay");
            myStack.Push(78);
            myStack.Push(9.4);
            myStack.Push("vikas");
            myStack.Push(false);
            myStack.Push(90);
          //Console.WriteLine(myStack.Pop());////output=90 ////pick out first from stack
            foreach (object item in myStack)
            {
                Console.WriteLine(item);
            }


        }
    }
    class proq
    {
        static void Main(string[] args)
        {
          Queue mm=new Queue();
            mm.Enqueue("ajay");
            mm.Enqueue(25);
            mm.Enqueue(9.8);
            mm.Enqueue("sanjay");
            mm.Dequeue();// deque first
            mm.Dequeue();//deque second

            foreach (object item in mm)
            {
                Console.WriteLine(item);
            }
        }
    }
    class demohashnongen
    {
        static void Main(string[] args)
        {
         Hashtable ht=new Hashtable();
            ht.Add(90, "A");
            ht.Add("b", 44);
            ht.Add("OM", 900);
            ht.Add(9.4f, 78);
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+"===>"+kv.Value);
            }
        }
    }
    class demohash
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("id", 101);
            ht.Add("Name", "akshay");
            ht.Add("salary", 70000);
            ht.Add("gen", "male");
            Console.WriteLine(ht["Name"]);//key dalo value palo
            Console.WriteLine(ht["id"]);//key dalo value palo


        }
    }
  
   
    
    
}
