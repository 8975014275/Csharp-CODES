using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            List<string>ll = new List<string>();
            ll.Add("akshay");
            ll.Add("vijay");
            ll.Add("sanjay");
            ll.Add("aman");
            ll.Add("yogesh");
            ll.Insert(2, "somesh");
           ll.Remove("sanjay");
            //  ll.RemoveAt(4);
            ll.Clear();
            foreach(string k in ll)
            {
                Console.WriteLine(k);
            }
        }
    }
    class ex2
    {
        static void Main(string[] args)
        {
            List<string> color = new List<string>();
            color.Add("blue");
            color.Add("red");
            color.Add("yellow");
            color.Add("white");
            color.Add("orange");
            color.Add("black");
            
            foreach(string k in color)
            {
                Console.WriteLine(k);
            }

        }
    }
    public static class ex3
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    public class Example
    {
        public static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            nums.Swap(2,3);
            Console.WriteLine(String.Join(", ", nums));      
        }
    }
    class ex4
    {
        static void Main(string[] args)
        {
            List<int>fm=new List<int>();
            fm.Add(78);
            fm.Add(89);
            fm.Add(75);
            fm.Add(98);
            fm.Add(95);
            foreach(int i in fm)
            {
                Console.WriteLine(i);
            }
            fm[1] = 90;//
            //fm.Insert(1, 100);
            Console.WriteLine("after repalce");
            foreach (int p in fm)
            {
                Console.WriteLine(p);
            }

        }
    }
    class stud//ex5
    {
        public string name;
        public int rollno;
        public int std;
        public stud(string name, int rollno, int std)
        {
            this.Name = name;
            this.Rollno = rollno;
            this.Std = std;
        }
        public override string ToString()
        {
            return "Name:" + name + "Rollno:" + rollno + "Std=" + std;
            //  return "[" + name + "," + rollno + "," + std + "]";
        }
        public string Name { get => name; set => name = value; }
        public int Rollno { get => rollno; set => rollno = value; }
        public int Std { get => std; set => std = value; }
    }
    class stud1
    {
        static void Main(string[] args)
        {
            List<stud> mm = new List<stud>();
            mm.Add(new stud("viky", 55, 12));
            mm.Add(new stud("sunny", 35, 10));
            mm.Add(new stud("vimal", 50, 11));
            mm.Add(new stud("nutaN", 55, 13));
            foreach (stud e in mm)
            {
                Console.WriteLine(e);
            }




        }
    }

    class ex6
    {
        static void Main(string[] args)
        {
            
            List<int> number = new List<int>();
          
            number.Add(10);
            number.Add(20);
            number.Add(15);
            number.Add(25);
            number.Add(30);
            number.Add(35);
            number.Add(40);
            number.Add(45);
          
            int[] a = number.ToArray();
            
            Console.WriteLine("the array elements are:");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ex7
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(100);
            num.Add(200);
            num.Add(300);
            num.Add(400);
            num.Add(500);
            foreach (int p in num)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("/////////");
            num.Reverse();
            foreach (int a in num)
            {
                Console.WriteLine(a);
            }
        }


    }
    class ex8
    {
        static void Main(string[] args)
        {
            List<string> student = new List<string>();
            student.Add("aman");
            student.Add("vikas");
            student.Add("sachin");
            student.Add("vishal");
            student.Add("dipak");

            foreach (string k in student)
            {
                Console.WriteLine(k);

            }
            Console.WriteLine("after the sorting names of student");
            student.Sort();
            foreach (string k in student)
            {
                Console.WriteLine(k);

            }



        }
    }
  
    public class Employee//EX.....9
    {
        public string name;
        public int age;
        public string designation;

        public Employee(string name, int age,string designation)
        {
            this.name = name;
            this.age = age;
            this.designation = designation;
        }

        public override string ToString()
        {
            return "[" + name + "," + age +","+ designation+"]";
        }
    }

    public class Exam
    {
        public static void Main()
        {
            Employee rajesh = new Employee("rajesh", 28,"HOD");
            Employee mahesh = new Employee("mahesh", 32,"CEO");
            Employee madan = new Employee("madan", 21,"HR");

            List<Employee> employees = new List<Employee>() { rajesh, mahesh, madan };
            employees.Sort((x, y) => x.age.CompareTo(y.age));

            Console.WriteLine(String.Join(Environment.NewLine, employees));
            Console.WriteLine("after the descending age");
            employees.Reverse();
            foreach(var employee in employees)
            {
                Console.WriteLine(employee);
            }



        }
    }
    class ex10
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> subject = new Dictionary<int, string>();
            subject.Add(101, "Hindi");
            subject.Add(102, "MARATHI");
            subject.Add(103, "ENGLISH");
            subject.Add(104, "SCIENCE");
            //ICollection<string> pp = subject.Values;  //to print only key element
            //foreach (string k in pp)
            //{
            //    Console.WriteLine(k);
            //}
            foreach (KeyValuePair<int, string> kvp in subject)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
    class EX11
    {
        static void Main(string[] args)
        {
            Dictionary<string,int>marks=new Dictionary<string,int>();
            marks.Add("MATH", 98);
            marks.Add("HISTORY", 90);
            marks.Add("ECONOMICS", 85);
            marks.Add("GEOGRAPHY", 92);
            marks.Add("ZOOLOGY", 87);
            Console.WriteLine("NAMES OF THE SUBJECT ARE");
            ICollection<string>cc=marks.Keys;
            foreach(string p in cc )
            {
                Console.WriteLine(p);
            }

        }
    }
    class ex12
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> subject = new Dictionary<int, string>();
            subject.Add(101, "Hindi");
            subject.Add(102, "MARATHI");
            subject.Add(103, "ENGLISH");
            subject.Add(104, "SCIENCE");
            Console.WriteLine("NAME OF THE SUBJECT");
            ICollection<string> pp = subject.Values;  //to print only key element
            foreach (string k in pp)
            {
                Console.WriteLine(k);
            }

        }
    }
    class Car//EX13
    {
        string name;
        int price;
        string company;
        public Car(string name, int price, string company)
        {
            this.Name = name;
            this.Price = price;
            this.Company = company;
        }
        public override string ToString()
        {
            return "Name:" + name + "Price:" + price + "Company" + company;
        }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Company { get => company; set => company = value; }

    }
    class demodictcustom
    {
        static void Main(string[] args)
        {
            Dictionary<Car, int> pp = new Dictionary<Car, int>();
            pp.Add(new Car("bolero", 50000, "MAhindra"), 1);
            pp.Add(new Car("nexon", 75000, "TATA"), 2);
            pp.Add(new Car("bolero", 870000, "MAhindra"), 3);
            pp.Add(new Car("scoda", 90000, "VOLKS"), 4);
            foreach (KeyValuePair<Car, int> p in pp)
            {
                Console.WriteLine(p);
            }


        }
    }


    class ex14
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);

            int remove =q.Dequeue();
        
            foreach (int p in q)
            {
                Console.WriteLine(p);
            }

        }
    }
    class ex15
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("Akshay");
            st.Push("Bheem");
            st.Push("Chetan");
            st.Push("vikas");
          
          // string dataremove = st.Pop();
             string datapeek=st.Peek();
             Console.WriteLine("datapeek:"+datapeek); 
          //  Console.WriteLine("removed:" + dataremove);
            foreach (string d in st)
            {
                Console.WriteLine(d);
            }
        }
    }
    class Empp//ex16
    {
        int eno;
        string name;
        string deptname;
        public Empp(int eno, string name, string deptname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Deptname = deptname;
        }
        public override string ToString()
        {
            return "Eno:" + eno + "Name:" + name + "Deptname:" + deptname;
        }
        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Deptname { get => deptname; set => deptname = value; }
    }
    class class18
    {
        static void Main(string[] args)
        {
            LinkedList<Empp> ll = new LinkedList<Empp>();
            ll.AddLast(new Empp(11, "nilesh", "quality"));
            ll.AddLast(new Empp(10, "mahesh", "production"));
            ll.AddLast(new Empp(15, "yogesh", "maintainance"));
            ll.AddLast(new Empp(30, "somesh", "production"));
            ll.AddLast(new Empp(20, "yogesh", "maintainance"));
            foreach (Empp e in ll)
            {
                Console.WriteLine(e);
            }
            string dname = "";
            Console.WriteLine("////////////");
            foreach (Empp e in ll)
            {
                if (e.Eno == 10)
                {
                    dname = e.Deptname;
                    break;
                }
            }
            foreach (Empp e in ll)
            {
                if (e.Deptname == dname)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }

    class exc17//multiple catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter the number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("devision" + a / b);
                Console.WriteLine("try end");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)//...universal handler it should be always last
            {
                Console.WriteLine(e.Message);
            }
            // SystemException s=new IndexOutOfRangeException();
            int[] p = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= p.Length; i += 2)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
    public class OddNumberException : Exception//.....ex18
    {
     
        public override string Message
        {
            get
            {
                return "divisor cannot be odd number";
            }
        }
    }
    class Programs
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("ENTER TWO INTEGER NUMBERS:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            try
            {
                if (y % 2 > 0)
                {
                   
                    throw new OddNumberException();
                }
                z = x / y;
                Console.WriteLine(z);
            }
            catch (OddNumberException one)
            {
                Console.WriteLine(one.Message);
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }
   
   
    
      
    




}
