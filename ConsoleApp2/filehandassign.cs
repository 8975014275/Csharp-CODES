using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int fees { get; set; }
    }
    class filebinerydemo//exmp1
    {
        static void WriteToFile(Course cs)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder1\TestFile2", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(cs.ID);
                bw.Write(cs.Name);
                bw.Write(cs.fees);
                bw.Close();
                fs.Close();
                Console.WriteLine("data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder1\TestFile2", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        static void Main(string[] args)
        {
            Course cs = new Course { ID = 101, Name = "Raju", fees = 25000 };
            WriteToFile(cs);
            ReadFromFile();

        }
    }
    class streamwr//exmp2
    {
        static void WriteToFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder1\TextDoc.txt1", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
              //  sw.WriteLine("sample text in file");
              string str=Console.ReadLine();
                sw.WriteLine(str);

                sw.Close();
                fs.Close();
                Console.WriteLine("done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder1\TextDoc.txt1", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void Main(string[] args)
        {
            WriteToFileUsingStream();
            ReadFromFileUsingStream();
        }
    }
}
