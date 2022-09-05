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
    [Serializable]
    public class COURSE
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public int fees { get; set; }
        public int duration { get; set; }
    }
    public class sericourse
    {
        static void JsonSerializationWrite(COURSE ct)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\JsonFile2.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<COURSE>(fs, ct);
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
                FileStream fs = new FileStream(@"D:\dotnet mvc\TestFolder\JsonFile2.json", FileMode.Open, FileAccess.Read);
                COURSE ct = JsonSerializer.Deserialize<COURSE>(fs);
                Console.WriteLine(ct.cid);
                Console.WriteLine(ct.cname);
                Console.WriteLine(ct.fees);
                Console.WriteLine(ct.duration);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            COURSE csd = new COURSE { cid = 101, cname = "CSHARP", fees = 5000,duration=5};
           
            JsonSerializationWrite(csd);
            JsonSerializationRead();




        }
    }
}
