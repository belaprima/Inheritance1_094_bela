using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek hp
            Phone galaxia10 = new Samsung();
            //membuat objek user
            PhoneUser nemo = new PhoneUser(galaxia10);
            //menyalakan hp
            nemo.turnOnThePhone();
            String aksi;
            while (true)
            {
                Console.WriteLine("\n=== APLIKASI INTERFACE ===");
                Console.WriteLine("[1] Nyalakan HP");
                Console.WriteLine("[2] Matikan HP");
                Console.WriteLine("[3] Perbesar Volume");
                Console.WriteLine("[4] Kecilkan Volume");
                Console.WriteLine("[0] Keluar");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pilih Aksi : ");
                aksi = Console.ReadLine();

                if (aksi.ToLower().Equals("1".ToLower()))
                {
                    nemo.turnOnThePhone();
                }
                else if (aksi.ToLower().Equals("2".ToLower()))
                {
                    nemo.turnOffThePhone();
                }
                else if (aksi.ToLower().Equals("3".ToLower()))
                {
                    nemo.makePhoneLouder();
                }
                else if (aksi.ToLower().Equals("4".ToLower()))
                {
                    nemo.makePhoneSilent();
                }
                else if (aksi.ToLower().Equals("0".ToLower()))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Maaf Pilihan Yang Anda Lakukan Salah!");
                }
            }
        }
    }
}
        

