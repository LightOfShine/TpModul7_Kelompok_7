﻿using System;
using System.IO;
using System.Text.Json;
using TpModul7_Kelompok_7;

namespace TpModul7_Kelompok_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM DESERIALISASI JSON ===");
            Console.WriteLine("=== Praktikum Modul 7 - NIM 2311104045 ===\n");

            // Jalankan fungsi pertama (Data Mahasiswa)
            Console.WriteLine("\n===============MENAMBAHKAN JSON DESERIALIZATON 1==================");
            Console.WriteLine("\n[1] MEMBACA DATA MAHASISWA");
            DataMahasiswa2311104045.ReadJSON();
            Console.ReadLine();
        }
    }
}
