using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class exm1
    {
        static void Main(string[] args)
        {
            List<string>ll = new List<string>();
            ll.Add("VIRAT");
            ll.Add("SACHIN");
            ll.Add("RAHUL");
            ll.Add("DINESH");
            ll.Add("ROHIT");
            ll.Add("SHIKHAR");
            foreach(string k in ll)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("after sorting");
            ll.Sort();
            foreach (string k in ll)
            {
                Console.WriteLine(k);
            }
        }
    }
    public class Emple//EXM....2
    {
        public string name;
        public string designation;
        public int salary;

        public Emple(string name, string designation, int salary )
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return "[" + name + "," + designation + "," + salary + "]";
        }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

    }
    class employ
    {
        static void Main(string[] args)
        {
            List<Emple>ab=new List<Emple>();
            ab.Add(new Emple("rajesh", "HR", 20000));
            ab.Add(new Emple("shubham", "CEO", 25000));
            ab.Add(new Emple("mahesh", "DATAENTRY", 12000));
            ab.Add(new Emple("sachin", "TRAINEE", 14000));
            foreach(Emple em in ab)
            {
                Console.WriteLine(em);
            }

        }
    }
    class exm3
    {
        static void Main(string[] args)
        {
            Queue<string> q= new Queue<string>();
            q.Enqueue("blue");
            q.Enqueue("red");
            q.Enqueue("pink");
            q.Enqueue("white");
            q.Enqueue("black");
            //  q.Dequeue();
            foreach(string c in q)
            {
                Console.WriteLine(c);
            }

        }
    }
    class exm5
    {
        static void Main(string[] args)
        {
          SortedList<int,string>h=new SortedList<int,string>();
            h.Add(101, "english");
            h.Add(106, "science");
            h.Add(108, "math");
            h.Add(100, "marathi");
            h.Add(103, "hindi");
            foreach(KeyValuePair<int,string>p in h)
            {
                Console.WriteLine(p.Key+"====>"+p.Value);
            }
          //  Console.WriteLine(h[101]);

        }
    }
    class exm6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> dd = new Dictionary<string, float>();
            dd.Add("circle", 3.14f);
            dd.Add("square", 7.2f);
            dd.Add("rectangle", 9.23f);
            dd.Add("cone", 6.674f);
            foreach(KeyValuePair<string, float>p in dd)
            {
                Console.WriteLine(p.Key+"====>"+p.Value);
            }

           
            
        }
    }
    class EMPLOYEE:IComparable<EMPLOYEE> //exm8
    {
        string nm;
        int experience;
        int salary;
        public EMPLOYEE(string nm, int experience, int salary)
        {
            this.NAME = nm;
            this.EXPERIENCE = experience;
            this.SALARY = salary;
            
        }
        public override string ToString()
        {
            return "NAME:" + nm +" "+ "EXPERIENCE:" + experience +" " +"SALARY:" + salary;
        }

        public int CompareTo(EMPLOYEE other)
        {
            return other.salary.CompareTo(this.salary);
        }

        public string NAME { get => nm; set => nm = value; }
        public int  EXPERIENCE { get => experience; set => experience = value; }
        public int SALARY { get => salary; set => salary = value; }
    }
    class empsorrt//discending order as per experience
    {
        static void Main(string[] args)
        {
            SortedList<EMPLOYEE,string>p=new SortedList<EMPLOYEE,string>();
            p.Add(new EMPLOYEE("pavan", 12, 35000), "IT");
            p.Add(new EMPLOYEE("radha", 2, 25000), "IT");
            p.Add(new EMPLOYEE("akshay", 1, 20000), "IT");
            p.Add(new EMPLOYEE("sanjay", 5, 45000), "IT");
            foreach(KeyValuePair<EMPLOYEE,string>kv in p)
            {
                Console.WriteLine(kv.Key+"===>"+kv.Value);


            }

        }
       
    }//exp 4
    //class EMP
    //{
    //    string nm;
    //    int experience;
    //    public EMP()
    //    {

    //    }
    //    public EMP(string nm, int experience)
    //    {
    //        this.nm = nm;
    //        this.experience = experience;
    //    }
    //    public string Nm
    //    {
    //        set { this.nm = value; }
    //        get { return this.nm; }
    //    }

    //    public override bool Equals(object? obj)
    //    {
    //        return obj is EMP eMP &&
    //               nm == eMP.nm &&
    //               experience == eMP.experience;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(nm, experience);
    //    }

    //    public override string ToString()
    //    {
    //        return "Name:" + nm + "Experience:" + experience;
    //    }
    //}
    class hastws
    {
        static void Main(string[] args)
        {

            HashSet<EMP> hP = new HashSet<EMP>();
            hP.Add(new EMP("aman", 25));
            hP.Add(new EMP("akash", 29));
            hP.Add(new EMP("sanjay", 20));
            hP.Add(new EMP("aman", 25));
            foreach (EMP e in hP)
            {
                Console.WriteLine(e);
            }

        }
    }
    class exmovie//EX7
    {
        static void Main(string[] args)
        {
            Stack<string> movie = new Stack<string>();
            movie.Push("DDLJ");
            movie.Push("KGF");
            movie.Push("KING");
            movie.Push("DON");
            foreach(string J in movie)
            {
                Console.WriteLine(J);
            }
            Console.WriteLine("//////");
            foreach(string J in movie)
            {
                Console.WriteLine(J);
            }

        }
    }
    class FLAT
    {

        int flatno;
        string wingname;
        public FLAT(int flatno, string wingname)
        {
            this.FLATNO = flatno;
            this.WINGNAME = wingname;

        }
        public override string ToString()
        {
            return "FLATNO:" + flatno + " " + "WINGNAME:" + wingname;
        }
        public int FLATNO { get => flatno; set => flatno = value; }
        public string WINGNAME { get => wingname; set => wingname = value; }

    }
    class MEMBER
    {
        int memberid;
        string membername;
        string profession;
        int age;
        public MEMBER(int memberid, string membername, string profession, int age)
        {
            this.memberid = memberid;
            this.membername = membername;
            this.profession = profession;
            this.age = age;
        }

        public int Memberid { get => memberid; set => memberid = value; }
        public string Membername { get => membername; set => membername = value; }
        public string Profession { get => profession; set => profession = value; }
        public int Age { get => age; set => age = value; }
    }
    //class exm9
    //{
    //    static void Main(string[] args)
    //    {
    //        List<FLAT>flit=new List<FLAT>();
    //        do
    //        {
    //            Console.WriteLine("enter the flatno and wing");
    //            int flatno=int.Parse(Console.ReadLine());
    //            string wing = Console.ReadLine();
    //            Console.WriteLine("enter the number of member in your flat");
    //            int n=int.Parse(Console.ReadLine());
    //            List<MEMBER>memberlist=new List<MEMBER>();
    //            for(int i=1;i<=n;i++)
    //            {
    //                Console.WriteLine("enter the member,profession,age");
    //                string mem=Console.ReadLine();
    //                string prof=Console.ReadLine();
    //                int age = int.Parse(Console.ReadLine());
    //                MEMBER mobj = new MEMBER(i, mem, prof, age);
    //                memberlist.Add(mobj);
    //            }
    //            flit.Add(new FLAT(flatno, wing, memberlist));
    //            Console.WriteLine("do you want to add one more flat detai");
    //            string choice=Console.ReadLine();
    //            if ((choice.ToLower() == "no"))
    //                break;

    //        }while(true);
    //        foreach(FLAT fl in flit)
    //        {
    //            Console.WriteLine("flatno"+fl.FLATNO);
    //            Console.WriteLine("wing"+fl.WINGNAME);
    //            List<MEMBER> mlst = fl.Memberlist;
    //            foreach(MEMBER m in mlst)
    //            {
    //                Console.WriteLine(m);
    //            }
    //        }
    //    }
    //}
}
    
  
        


     




