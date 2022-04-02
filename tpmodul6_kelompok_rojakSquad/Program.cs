
﻿using System;

namespace tpmodul6_kelompok_rojakSquad // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataMahasiswa_1302202072 r = new DataMahasiswa_1302202072();
            r.readJson();

            kuliahMahasiswa_1302202072 k = new kuliahMahasiswa_1302202072();
            k.readJson();
        }
    }
}
