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
    internal class DataMahasiswa_1302202072
    {
        public void readJson()
        {
            StreamReader r = new StreamReader("tp6_1_1302202072.json");
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);

            var nama = parsed["nama"];
            var depan = nama["depan"].Value<String>();
            var belakang = nama["belakang"].Value<String>();

            Console.WriteLine("Nama {0} {1} dengan nim {2} dari fakultas {3} ",depan,belakang, parsed["nim"].Value<String>(), parsed["fakultas"].Value<String>());



            
        }
    }
}
