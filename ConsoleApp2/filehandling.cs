using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp2
{
    internal class filedemo
    {
        static void Createfolder()
        {
            string path =@"D:\dotnet mvc\TestFolder";
            if(Directory.Exists(path))
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                
                    Console.WriteLine("folder is created");
                
            }
        }
        static void CreateFile()
        {
            string path = @"D:\dotnet mvc\TestFolder\TestFile.txt";
            {
                if(File.Exists(path))
                {
                    Console.WriteLine("file already exist");
                }
                else
                {
                    File.Create(path);
                    Console.WriteLine("file is created");

                }
            }
        }
        static void Main(string[] args)
        {
            Createfolder();
            CreateFile();


        }

    }
    public class Dept
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
    }
    internal class filedemo1
    {
        static void Createfolder()
        {
            string path = @"D:\dotnet mvc\TestFolder1";
            DirectoryInfo d=new DirectoryInfo(path);

            if (d.Exists)
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                d.Create();

                Console.WriteLine("folder is created");

            }
        }
        static void CreateFile()
        {
            string path = @"D:\dotnet mvc\TestFolder\TestFile1.txt";
          FileInfo f=new FileInfo(path);
            {
                if (f.Exists)
                {
                    Console.WriteLine("file already exist");
                }
                else
                {
                    f.Create();
                    Console.WriteLine("file is created");

                }
            }
        }
        static void WriteToFile(Dept dept)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(dept.ID);
                bw.Write(dept.Name);
                bw.Write(dept.location);
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
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\TestFile", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void WriteToFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\TextDoc.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw=new StreamWriter(fs);
                sw.WriteLine("This is sample text in the file");
                
                sw.Close();
                fs.Close();
                Console.WriteLine("done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\TextDoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr=new StreamReader(fs);
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
            //Dept dept = new Dept { ID = 1, Name = "Hr", location = "pune" };
            //WriteToFile(dept);
            //ReadFromFile();
            WriteToFileUsingStream();
            ReadFromFileUsingStream();

        }
       
    }
  
   
}
