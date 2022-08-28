using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Serialization;




namespace ConsoleApp2
{
    //add attribute on the top of class,this information will be pass to the clr
    [Serializable]
    public class Students
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double percentage { get; set; }

    }
    internal class seri
    {
        static void JsonSerializationWrite(Students st)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Students>(fs, st);
                Console.WriteLine("json  data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Students st = JsonSerializer.Deserialize<Students>(fs);
                Console.WriteLine(st.RollNo);
                Console.WriteLine(st.Name);
                Console.WriteLine(st.percentage);
                fs.Close();
            }                 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void SoapSerializationWrite(Students st)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, st);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Students st = (Students)sf.Deserialize(fs);
                Console.WriteLine(st.RollNo);
                Console.WriteLine(st.Name);
                Console.WriteLine(st.percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void XmlSerializationWrite(Students st)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\XmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Students));
                xs.Serialize(fs, st);
                Console.WriteLine("Xml data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\XmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Students));
                Students st = (Students)xs.Deserialize(fs);
                Console.WriteLine(st.RollNo);
                Console.WriteLine(st.Name);
                Console.WriteLine(st.percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void BinerySerializationWrite(Students st)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, st);
                Console.WriteLine("binery data added");
                fs.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        
        static void BinerySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Students st = (Students)bf.Deserialize(fs);
                Console.WriteLine(st.RollNo);
                Console.WriteLine(st.Name);
                Console.WriteLine(st.percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void Main(string[] args)
        {
            Students std = new Students { RollNo = 101, Name = "Suraj", percentage = 89.44 };
            //  BinerySerializationWrite(std);
            //BinerySerializationRead();
           // XmlSerializationWrite(std);
          //  XmlSerializationRead();
          //  SoapSerializationWrite(std);
            //SoapSerializationRead();
            JsonSerializationWrite(std);
            JsonSerializationRead();




        }

    }
}
