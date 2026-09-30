// Game
// Genre : PvP
// Karakter : Nama, Kesehatan, 

using System;
using System.Reflection.Metadata.Ecma335;
namespace KarakterGame
{
    class Karakter
    {
        
        //enskapsolution
        public string nama{get; private set;}
        public string kesehatan{get; private set;}
        public string senjata{get; private set;}
        public int jumlahSenjata{get; private set;}
        public int Power{get; private set;}

        public Karakter(string nama, string kesehatan, string senjata, int jumlahSenjata, int Power) //membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
            this.jumlahSenjata = jumlahSenjata;
            this.Power = Power;
        }



        // public void setData(string namaBaru, string Kesehatanku, string Senjataku, int jumlahSenjata, int Power)
        // {
        //     this.nama = namaBaru;
        //     this.kesehatan = Kesehatanku;
        //     this.senjata = Senjataku;
        //     this.jumlahSenjata = jumlahSenjata;
        //     this.power = Power;
        // }

        // public void getData()
        // {
        //     Console.Write(nama);
        //     Console.Write("/");
        //     Console.Write(kesehatan);
        //     Console.Write("/");
        //     Console.Write(senjata);
        //     Console.Write("/");
        //     Console.Write(jumlahSenjata);
        //     Console.Write("/");
        //     Console.WriteLine(Power.ToString("N0"));
        // }

        public void aiiii()
        {
            Console.WriteLine($"Nama Karakter : {nama}");
            Console.WriteLine($"Keadaan Karakter : {kesehatan}");
            Console.WriteLine($"Senjata Karakter : {senjata}");
            Console.WriteLine($"Jumlah senjata Karakter : {jumlahSenjata}");
            Console.WriteLine($"Kekuatan Karakter : {Power}");


        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter player1 = new Karakter("rusdi", "prot prot", "stick of humanity", 1, 1000000000);
            player1.aiiii();
//             Kodesebelumnya
//             List<Karakter> daftarHero = new List<Karakter>();

//             Karakter player1 = new Karakter();
//             player1.setData("Kipli", "Sehat", "Pistol", 2 , 25);
//             //player1.getData();

//             Karakter player2 = new Karakter();
//             player2.setData("Putri", "Sehat", "Tongkat", 1, 10);
//             //player2.getData();

//             //player.setKesehatan("Sehat");
//             //player.getKesehatan(); //metode membuat method baru

//             //Objek Musuh
//             Karakter enemy = new Karakter();
//             enemy.setData("Zobie", "sehat", "Tangan Kosong", 1, 15);
//             enemy.getData();

//             daftarHero.Add(player1);
//             daftarHero.Add(player2);

//             //menampilkan data diri array, foreach
//             foreach(Karakter player in daftarHero)
//             {
//                 player.getData();
            }
        }
    }
// }