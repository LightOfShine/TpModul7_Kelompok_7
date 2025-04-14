using System;
using System.IO;
using System.Text.Json;

namespace TpModul7_Kelompok_7
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa2311104043
    {
        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_1_2311104043.json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File \"{filePath}\" tidak ditemukan!");
                    Console.WriteLine("Lokasi pencarian: " + Path.GetFullPath(filePath));
                    return;
                }

                // Baca dan deserialize file JSON
                string jsonString = File.ReadAllText(filePath);
                DataMahasiswa? data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

                if (data != null && data.nama != null)
                {
                    Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} " +
                        $"dengan NIM {data.nim} dari fakultas {data.fakultas}");
                }
                else
                {
                    Console.WriteLine("Data tidak valid atau kosong.");
                }
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Error saat parsing JSON: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}