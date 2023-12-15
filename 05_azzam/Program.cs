using System;
using System.Collections;

namespace bangun_ruang
{
    public static class Program
    {
        public static void Main()
        {
            string respon;
            do
            {
                //identitas
                //menampilkan judul
                Console.WriteLine("Welcome (^_^)");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Aplikasi Penghitung Volume Bangun Ruang Dari : ");
                Console.WriteLine("Nama     : Azzam Ahmad Zain2");
                //Guru Pembibing : 
                // 1. Moh. Shobirin
                // 2. Halimatus Sa'diyah
                // 3. Moh. Wildam
                Console.WriteLine("Sekolah  : SMK Negri 1 Bangil");
                Console.WriteLine("Kelas    : X-PPLG");
                Console.WriteLine("No.Absen : 05");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                //pilihan bangun ruang
                Console.WriteLine("***********************************");
                Console.WriteLine("Menu Bangun Ruang :");
                Console.WriteLine("1. Balok");
                Console.WriteLine("2. Kubus");
                Console.WriteLine("3. Tabung");
                Console.WriteLine("4. Kerucut");
                Console.WriteLine("5. Bola");
                Console.WriteLine("***********************************");
                Console.Write("Masukkan Pilihan Anda : ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        //rumus volume balok
                        Console.WriteLine("==============================");
                        Console.WriteLine("Rumus Volume Balok = P x L x T");
                        Console.WriteLine("==============================");
                        //untuk menginput panjang balok yang ingin di hitung
                        Console.Write("Masukkan Panjang Balok : ");
                        double P = Convert.ToDouble(Console.ReadLine());
                        //untuk menginput lebar balok yang ingin di hitung
                        Console.Write("Masukkan Lebar Balok   : ");
                        double L = Convert.ToDouble(Console.ReadLine());
                        //untuk menginput tinggi yang ingin di hitung
                        Console.Write("Masukkan Tinggi Balok  : ");
                        double T = Convert.ToDouble(Console.ReadLine());

                        //untuk proses menghitung
                        double total = P * L * T;
                        //untuk menampilkan hasil hitung
                        Console.WriteLine("Volume Balok Adalah : " + total);
                        break;

                    case 2:
                        //rumus volume kubus
                        Console.WriteLine("==============================");
                        Console.WriteLine("Rumus Volume Kubus = S x S x S");
                        Console.WriteLine("==============================");
                        //untuk menginput besar sisi kubus yang ingin di hitung
                        Console.Write("Masukkan Sisi Kubus : ");
                        double S = Convert.ToDouble(Console.ReadLine());

                        //untuk proses menghitung
                        double totalnya = S * S * S;
                        //untuk menampilkan hasil hitung
                        Console.WriteLine("Volume Kubus Adalah : " + totalnya);
                        break;

                    case 3:
                        //rumus menghitung volume tabung 
                        Console.WriteLine("================================================");
                        Console.WriteLine("Rumus Volume Tabung = 22/7 atau 3.14 x r x r x t");
                        Console.WriteLine("================================================");
                        //untuk menginput jari-jari tabung yang ingin di hitung
                        Console.Write("Masukkan jari-jari Tabung : ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        //untuk menginput tinggi tabung yang ingin di hitung
                        Console.Write("Masukkan tinggi Tabung    : ");
                        double t = Convert.ToDouble(Console.ReadLine());

                        //untuk proses menghitung
                        double hasil = 3.14 * r * r * t;
                        //untuk menampilkan hasil hitung
                        Console.WriteLine("Volume Tabung Adalah : " + hasil);
                        break;

                    case 4:
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Rumus Volume Kerucut = 1/3 x 22/7 atau 3.14 x r x r x t");
                        Console.WriteLine("=======================================================");
                        //untuk menginput jari-jari kerucut yang ingin di hitung
                        Console.Write("Masukkan jari-jari Kerucut : ");
                        double R = Convert.ToDouble(Console.ReadLine());
                        //untuk menginput tinggi kerucut yang ingin di hitung
                        Console.Write("Masukkan tinggi Kerucut    : ");
                        double Ti = Convert.ToDouble(Console.ReadLine());

                        //untuk proses menghitung
                        double hasilnya = 1 / 3 * 3.14 * R * R * Ti;
                        //untuk menampilkan hasil hitung
                        Console.WriteLine("Volume Kerucut Adalah : " + hasilnya);
                        break;

                    case 5:
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Rumus Volume Bola = 4/3 x 22/7 atau 3.14 x r x r x r");
                        Console.WriteLine("====================================================");
                        Console.Write("Masukkan jari-jari Bola : ");
                        double jari = Convert.ToDouble(Console.ReadLine());

                        //untuk proses menghitung
                        double HASIL = 4 / 3 * 3.14 * jari * jari * jari;
                        //untuk menampilkan hasil hitung
                        Console.WriteLine("Volume Kerucut Adalah : " + HASIL);
                        break;
                    //default untuk menunjukkan menu yang tidak tersedia
                    default:
                        Console.WriteLine("Maaf Pilihan Anda Tidak Ditemukan");
                        break;
                }

                Console.WriteLine("Ingin Menghitung Ulang ?");
                Console.Write("Y/N : ");
                respon = Convert.ToString(Console.ReadLine());
                Console.Clear();
                //console clear untuk membersihkan history
            } while (respon == "Y" || respon == "y");
            //UNTUK MENGULANG 
            // jika "Y" maka akan kembali ke menu untuk memilih ulang menu
            // jika "N" maka perhitungan akan selesai


        }//masalah : eror pada case
        //solusi : menambahkan "break;"

    }

}