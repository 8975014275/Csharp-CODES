using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    internal class genlist
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            {
                lst.Add(100);
                lst.Add(200);
                lst.Add(300);
                lst.Add(400);
                lst.Add(500);
                lst.Add(300);
                lst.Add(300);
                lst.Add(300);
                lst.Add(300);
                lst.Add(300);
                // lst[0] = 1000;
                Console.WriteLine(lst.Count);
                Console.WriteLine(lst.Capacity);
                // Console.WriteLine(lst);
                for (int i = 0; i < lst.Count; i++)
                    Console.WriteLine(lst[i]);
                foreach (int data in lst)
                    Console.WriteLine(data);

                // lst.Clear();
                Console.WriteLine((lst.Contains(90)));
                Console.WriteLine("indexof" + lst.IndexOf(309));
                List<int> lst2 = new List<int>() { 111, 112, 113 };
                lst2.AddRange(lst);
                //  lst2.InsertRange(1, lst);
                for (int i = 0; i < lst2.Count; i++)
                {
                    Console.Write(lst2[i] + " ");
                }
            }
        }



    }
    class eef//list practice
    {
        public static void Main(string[] args)
        {
            List<string> student = new List<string>();
            student.Add("AKSHAY");
            student.Add("MOHAN");
            student.Add("SOHAN");
            student.Add("ROHAN");
            student.Add("MOHAN");
            Console.WriteLine(student.Capacity);
            Console.WriteLine(student.Count);
         //   Console.WriteLine(student[2]);

            ////for (int i = 0; i < student.Count; i++)
            ////{

            ////    Console.WriteLine(student[i]);
            ////}
            ////foreach (string s in student)
            ////{
            ////    Console.WriteLine(s);
            ////}

        }
    }
    class eef3//linked list node practicing
    {
        static void Main(string[] args)
        {
            LinkedList<string> stud = new LinkedList<string>();
            stud.AddLast("ajay");
            stud.AddLast("ramesh");
            stud.AddFirst("vivek");
            LinkedListNode<string> node = stud.Find("vivek");
            stud.AddAfter(node, "giri");
            stud.AddBefore(node, "akshay");

            foreach (string p in stud)
            {
                Console.WriteLine(p);
            }

        }
    }
    class dicstudent
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> student = new Dictionary<int, string>();
            student.Add(1, "AMAN");
            student.Add(2, "MOHAN");
            student.Add(3, "ROHAN");
            student.Add(4, "SOHAN");
            //ICollection<int>pp=student.Keys;  //to print only key element
            //foreach(int k in pp)
            //{
            //    Console.WriteLine(k);
            //}
            foreach (KeyValuePair<int, string> kvp in student)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.WriteLine("ENTER THE KEY FOR SEARCH");
            int i = int.Parse(Console.ReadLine());
            if (student.ContainsKey(i))
            {
                Console.WriteLine("student name is found:" + student[i]);
            }
            else
                Console.WriteLine("student entry not found");
            student.Remove(i);
            Console.WriteLine("after removing the entrty");
            foreach (KeyValuePair<int, string> kvp in student)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
    class class14
    {
        static void Main(string[] args)
        {
            //List<Emp> ll = new List<Emp>();
            //  ll.Add(new Emp("AKSH", 9));
            //  ll.Add(new Emp("akshay",8));

            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("AKSHAY", 90);
            dd.Add("AJAY", 90);
            dd.Add("RAMESH", 88);
            dd.Add("SHUBHAM", 91);
            Console.WriteLine(dd["RAMESH"]);


            dd.Remove("AKSHAY");
            // dd.Clear();
            dd.ContainsKey("jyoti");
            dd.ContainsValue(90);
            foreach (KeyValuePair<string, int> kp in dd)
                Console.WriteLine(kp.Key + " =>" + kp.Value);

        }
    }
    class dictprogram//practicing...
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mydict = new Dictionary<string, string>();
            mydict.Add("active", "ready to engage");
            mydict.Add("amazing", "causing great surprise");
            mydict.Add("honest", "truthful behaviour");
            mydict.Add("quarantine", "place of isolation");
            mydict.Add("patriotic", "expressing devotion");
            // Console.WriteLine(mydict["active"]);
            foreach (KeyValuePair<string, string> item in mydict)
            {
                Console.WriteLine("key is: " + item.Key + "value is: " + item.Value);
            }
        }
    }
    class EMP
    {
        string nm;
        int experience;
        public EMP()
        {

        }
        public EMP(string nm, int experience)
        {
            this.nm = nm;
            this.experience = experience;
        }
        public string Nm
        {
            set { this.nm = value; }
            get { return this.nm; }
        }

        public override bool Equals(object? obj)
        {
            return obj is EMP eMP &&
                   nm == eMP.nm &&
                   experience == eMP.experience;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nm, experience);
        }

        public override string ToString()
        {
            return "Name:" + nm + "Experience:" + experience;
        }
    }
    class Demohash
    {
        static void Main(string[] args)
        {
            string s1 = new string("AMIT");
            string s2 = new string("AMIT");
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            EMP e = new EMP("OM", 3);
            EMP e2 = new EMP("OM", 3);
            Console.WriteLine(e.GetHashCode());
            Console.WriteLine(e2.GetHashCode());

        }
    }
    class DICTDEMO
    {
        static void Main(string[] args)
        {
            Dictionary<EMP,int>d2=new Dictionary<EMP,int>();
            d2.Add(new EMP("Omkar", 9), 987777777);
            d2.Add(new EMP("Omkar", 9), 987777777);
            foreach(KeyValuePair<EMP,int>kp in d2)
            {
                Console.WriteLine(kp.Key+"===>"+kp.Value);
            }
            
            
        }
    }

    class dict1
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("NILESH", 90);
            dd.Add("DHIRAJ", 90);
            dd.Add("SHUBHAM", 91);
            dd.Add("RAJ", 92);
            ICollection<string> CC = dd.Keys;
            foreach (string k in CC)
                Console.WriteLine(k);
        }
    }
    class listremovedup
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>()
            { "red","pink","blue","red","yellow"};
            Console.WriteLine("enter color to be deleted");
            string colortodeleted = Console.ReadLine();
            ll.Remove(colortodeleted);
            while (true)
            {
                int idx = ll.IndexOf(colortodeleted);
                if (idx != -1)

                    ll.RemoveAt(idx);
                else
                    break;

            }
            foreach (string d in ll)
            {
                Console.WriteLine(d);
            }
        }
    }
    class DemoStack
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Clear();
            string dataremove = st.Pop();
            //  string datapeek=st.Peek();
            //  Console.WriteLine("datapeek:"+datapeek); //show only not remove
            Console.WriteLine("removed:" + dataremove);
            foreach (string d in st)
            {
                Console.WriteLine(d);
            }
        }
    }
    class demostackcopyto
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("akshay");
            st.Push("vivek");
            st.Push("rahul");
            st.Push("rohan");
            string[] ar = new string[st.Count];
            st.CopyTo(ar, 0);
            foreach (string s in ar) 
            {
                Console.WriteLine(s);
            }

        }
    }
    class demoquee
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);

            int remove = q.Dequeue();
            foreach (int p in q)
            {
                Console.WriteLine(p);
            }

        }
    }
    class exmsortedlist
    {
        static void Main(string[] args)
        {
            SortedList<int, string> student = new SortedList<int, string>();
            student.Add(4, "aman");
            student.Add(3, "vikas");
            student.Add(1, "sachin");
            student.Add(5, "vishal");
            student.Add(2, "dipak");
            foreach (KeyValuePair<int, string> p in student)
            {
                Console.WriteLine(p.Key + " " + p.Value);
            }


        }
    }
    class classsortedlist
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("devesh", 90);
            ss.Add("amey", 90);
            ss.Add("chirag", 90);
            ss.Add("siya", 90);
            ss.Add("saif", 90);
            ss.Add("tanish", 90);
            ss.Add("harsh", 90);
            ss["devesh"] = 99;
            Console.WriteLine(ss.ContainsKey("riya"));
            ss.Remove("amey");
            foreach (KeyValuePair<string, int> kv in ss)
            {
                Console.WriteLine(kv.Key + "===>" + kv.Value);
            }


        }
    }
    class studen : IComparable<studen>    //sorted list
    {
        string sname;
        long mob;
        int percent;
        public studen(string sname, long mob, int percent)
        {
            this.Sname = sname;
            this.Mob = mob;
            this.Percent = percent;

        }
        public override string ToString()
        {
            return "Sname:" + sname + "Mob:" + mob + "Percent=" + percent;
        }

        public int CompareTo(studen other)
        {
            Console.WriteLine("OTHER=" + other);
            Console.WriteLine("this=" + this);
            //if (this.percent < other.percent)
            //    return -1;
            //else if (this.percent > other.percent)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            if (this.percent == other.percent)
                if (this.Sname == other.Sname)
                    return this.mob.CompareTo(other.Mob);
                else
                    return this.Sname.CompareTo(other.Sname);
            else
                return this.percent.CompareTo(other.percent);
            //return other.sname.CompareTo(this.sname);.......USE OTHER FIRST FOR DISCENDING
        }

        public string Sname { get => sname; set => sname = value; }
        public long Mob { get => mob; set => mob = value; }
        public int Percent { get => percent; set => percent = value; }

    }
    class Demostud
    {
        static void Main(string[] args)
        {
            SortedList<studen, string> ss = new SortedList<studen, string>();
            ss.Add(new studen("RAJ", 678678686, 88), "JAVA");
            ss.Add(new studen("VIRAJ", 878678686, 90), "JAVA");
            ss.Add(new studen("AJAY", 978678786, 90), "JAVA");
            ss.Add(new studen("RADHA", 9678678686, 78), "JAVA");
            ss.Add(new studen("NILESH", 988178686, 98), "JAVA");
            foreach (KeyValuePair<studen, string> kv in ss)
            {
                Console.WriteLine(kv.Key + "====>" + kv.Value);
            }
        }
    }
    class Empl : IComparable<Empl>
    {
        int eno;
        string name;
        string deptname;
        public Empl(int eno, string name, string deptname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Deptname = deptname;
        }
        public override string ToString()
        {
            return "Eno:" + eno + "Name:" + name + "Deptname:" + deptname;
        }

        public int CompareTo(Empl other)
        {
            return this.name.CompareTo(other.name);
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Deptname { get => deptname; set => deptname = value; }
    }
    class demoempp
    {
        static void Main(string[] args)
        {
            SortedList<Empl, string> st = new SortedList<Empl, string>();
            st.Add(new Empl(104, "vinay", "it"), "MR");
            st.Add(new Empl(101, "saket", "qc"), "HR");
            st.Add(new Empl(106, "akshay", "main"), "CEO");
            st.Add(new Empl(100, "bhumi", "it"), "SE");
            foreach (KeyValuePair<Empl, string> kvp in st)
            {
                Console.WriteLine(kvp);
            }


        }


    }
    class contry//PRACTICE
    {
        static void Main(string[] args)
        {
            var ambassadors = new Dictionary<Countrycode, Ambassador>();
            Ambassador england = new Ambassador
            {
                Countrycode = new Countrycode("eng"),
                Name = "John",
                Age = 30,
            };

            Ambassador australia = new Ambassador
            {
                Countrycode = new Countrycode("aus"),
                Name = "Ana",
                Age = 31,
            };

            ambassadors.Add(england.Countrycode, england);
            ambassadors.Add(australia.Countrycode, australia);
            Console.WriteLine("Enter country code: ");
            var code = Console.ReadLine();
            if (ambassadors.TryGetValue(new Countrycode(code), out Ambassador ambassador))
            {
                Console.WriteLine($"The ambassador is {ambassador.Name}");
            }
            else
                Console.WriteLine("The ambassador with the given code does not exist" + "In the dictionary");
        }
    }
    public class Countrycode
    {
        public string Code { get; }
        public Countrycode(string code)
        {
            Code = code;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Countrycode))
            {
                return false;
            }
            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((Countrycode)obj).Code);

        }
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code);

        }

    }
    public class Ambassador
    {
        public Countrycode Countrycode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }



    }
    class myStringBuilderSort : IComparer<StringBuilder>  //ICOPARER INTERFACE FOR NOT ORIGINAL CLASS 
    {
        public int Compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class Demosss
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(new StringBuilder("Amit"), 90000);
            sb.Add(new StringBuilder("Sumit"), 90000);
            sb.Add(new StringBuilder("Meet"), 90000);
            sb.Add(new StringBuilder("Amita"), 90000);
            sb.Add(new StringBuilder("Siya"), 90000);
            foreach(KeyValuePair<StringBuilder, int> kvp in sb)
            {
                Console.WriteLine(kvp.Key+"==>"+kvp.Value);
            }
        }//TO MAKE CUSTOM object(class)immutable ==>use readonly keyword before instance property.readonly similar to static 
        //whwreas const keyword asign value at compile time ex const int id=10;
    }
    //sealed class student1:IComparable<student1>///custom immutable
    //{
    //    readonly string sname;
    //    readonly long  mob;
    //    readonly int percent;
    //    public student1(string sname, long mob, int percent)
    //    {
    //         Sname = sname;
    //        Mob = mob;
    //        Percent = percent;
    //    }
    //    public string Sname { get; }
    //    public long Mob { get; }
    //    public int Percent { get; }
    //}
    class class21
    {
        static void Main(string[] args)
        {
            //uniq individual object
             List<string> lst = new List<string>() { "A", "B", "C", "A", "E", "B" };
            HashSet<string> hs = new HashSet<string>(lst);
          //  if custom object used in hashcode equal and gethashcode must override.
            //hs.Add("om");
            //hs.Add("riya");
            //hs.Add("siya");
            //hs.Add("riya");
            foreach (string s in hs)
            {
                Console.WriteLine(s);
            }

        }
    }
    //This method removes all elements from collection 1 that are matched with elements in collection 2.=Exceptwith
    //This method is used to combine both the collection. See below code snippet to get a better understanding,=unionwith
    //This Method returns common elements from both collections.=intersectwith
    class hsshet
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "om", "raj", "ram" };
            HashSet<string> hs2 = new HashSet<string>() { "omkar", "raj", "ram" };
            //  HashSet<string>hs3=hs1.Intersect(hs2).ToHashSet(); ;   //common element
            //  hs1.IntersectWith(hs2);
            //  hs1.UnionWith(hs2);
            bool b1 = hs1.IsSubsetOf(hs2);
            bool b2 = hs1.IsSupersetOf(hs2);

            foreach (string s in hs1)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine();
            
            foreach (string s in hs2)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine();
            //foreach (string s in hs3)
            //{
            //    Console.Write(s+" ");
            //}
        }
    }
    class mySort : IComparer<Empp>
    {
        public int Compare(Empp e1, Empp e2)
        {
            return e1.Name.CompareTo(e2.Name);
        }
    }
    class demosortedtest
    {
        static void Main(string[] args)
        {
            //duplicate not allowed
            //SortedSet<string> hs = new SortedSet<string>();
            //hs.Add("Raman");
            //hs.Add("Leena");
            //hs.Add("Heena");
            //hs.Add("Beena");
            //hs.Add("Raman");
            //foreach (string d in hs)
            //{
            //    Console.WriteLine(d);
            //}
            SortedSet<Empp> hd = new SortedSet<Empp>(new mySort());
            hd.Add(new Empp(12, "om", "IT"));
            hd.Add(new Empp(13, "trisha", "IT"));
            hd.Add(new Empp(2, "risha", "testing"));
            
            foreach (Empp e in hd)
            {
                Console.WriteLine(e);
            }





        }
    }
    class dsorttest  //duplicate element remove
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>() { "b", "c", "b", "d", "e","d" };
            SortedSet<string> l = new SortedSet<string>(ll);
            foreach(string s in l)
            {
                Console.WriteLine(s);
            }

            

        }
    }
 

    



}
 




  
      





    
 