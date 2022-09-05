using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp2
{

    static class DBConnect
    {
        public static SqlConnection getConnection()
        {
            string str = "server=AKSHPC\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                // con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return con;


        }
    }
    class demoupdate//updated query
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            con.Open();
            Console.WriteLine("enter sid,nm,marks");
            int sid = int.Parse(Console.ReadLine());
            string sname = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cd = new SqlCommand("update studunt set sname=@nm,marks=@mk where sid=@id", con);
            cd.Parameters.AddWithValue("@id", sid);
            cd.Parameters.AddWithValue("@nm", sname);
            cd.Parameters.AddWithValue("@mk", marks);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("record updated successfully");
            }
            else
                Console.WriteLine("failed to update");

        }
    }
    class demodelete//delete query
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            con.Open();
            Console.WriteLine("enter sid");
            int sid = int.Parse(Console.ReadLine());
            SqlCommand cd = new SqlCommand("delete from studunt where sid=@id", con);
            cd.Parameters.AddWithValue("@id", sid);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("record deleted successfully");
            }
            else
                Console.WriteLine("failed to delete");
        }
    }
    class DEMOInsert //insert query
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            con.Open();
            Console.WriteLine("enter id,nm,percent");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cd = new SqlCommand("insert into studunt values(@id,@nm,@mk)", con);
            cd.Parameters.AddWithValue("@id", rollno);
            cd.Parameters.AddWithValue("@nm", nm);
            cd.Parameters.AddWithValue("@mk", marks);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("record inserted");


        }
        static void Main1(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cd = new SqlCommand("insert into studunt values(1,'akshay',98)", con);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("record inserted");
        }
    }
    internal class ADDODEMO
    {
        static void Main(string[] args)
        {
            string str = "server=AKSHPC\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select first_name,salary from employees", con);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Name=" + dr["first_name"] + "salary=" + dr[1]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();

            }
        }
    }
}


