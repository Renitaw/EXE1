using System;

namespace ExerAlgo_1
{

    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] Renita = new int[34];

        // Deklarasi variabel int untuk menyimpan banyak data pada array
        private int n;
   
        // Fungsi / Method untuk menerima masukan
        private void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 34)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 34 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Renita[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int RW = 0; RW < n; RW++)
            {
                Console.WriteLine(Renita[RW]);
            }
            Console.WriteLine("");
        }
        public void RenitaArray()
        {
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int RW = 0; RW < n - 2; RW++)
                {
                    if (Renita[RW] <  Renita[RW + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = Renita[RW];
                        Renita[RW] = Renita[RW + 1];
                        Renita[RW + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the ExerAlgo_1 class
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.RenitaArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}

    

    