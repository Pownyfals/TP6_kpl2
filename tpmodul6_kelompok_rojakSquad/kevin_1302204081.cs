using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace tpmodul6_kelompok_rojakSquad
{
	
	public class kevin_1302204081
	{
		public string nama { set; get; }
		public int nim { set; get; }
		public string fakultas {set;get;}
	}

	public class matkul_1302204081
	{
		public string kodeMatkul { get; set; }
		public string namaMatkul{ set; get; }
	}
	public class Program
	{
		public static void Main()
		{
			var json = @"C:\College\Programming\Konstruksi Perangkat Lunak\TP\TP6\
			tpmodul6_kelompok_rojakSquad\tpmodul6_kelompok_rojakSquad\tp6_1_1302204081.json";

			var option = new JsonSerializerOptions
			{
				IncludeFields = true,
			};
			var kevin = JsonSerializer.Deserialize<kevin_1302204081>(json);

			Console.WriteLine($"nama {kevin.nama} dengan nim {kevin.nim} dari fakultas {kevin.fakultas}");

			var json2 = @"C:\College\Programming\Konstruksi Perangkat Lunak\TP\TP6
			\tpmodul6_kelompok_rojakSquad\tpmodul6_kelompok_rojakSquad\tp6_2_1302204081.json";
			var matkul = JsonSerializer.Deserialize<matkul_1302204081>(json2);
		}
	}

		
	
}
