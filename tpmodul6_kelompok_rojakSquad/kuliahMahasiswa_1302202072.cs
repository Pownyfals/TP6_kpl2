using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace tpmodul6_kelompok_rojakSquad
{
    internal class kuliahMahasiswa_1302202072
    {
        public void readJson()
        {
            StreamReader r = new StreamReader("tp6_2_1302202072.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

            var arr = parsed["courses"];
            int i = 1;
            foreach (var item in arr)
            {
                
                Console.WriteLine("MK {0} {1}-{2}", i, item["code"], item["name"]);
                i+=1;
            }
            
            
            
            
            




        }
    }
}
