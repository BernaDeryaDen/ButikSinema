using System;

namespace ButikSinema_G022
{
    class Program
    {
        static Sinema Snm;
        static void Main(string[] args)
        {
            Uygulama();
        }



        static void Test()
        {
            int sayi1 = SayiAl("1. Sayiyı girin: ");
            int sayi2 = SayiAl("2. Sayiyı girin: ");
            Console.WriteLine("Sayıların toplamı: " + (sayi1 + sayi2));
        }
        static int SayiAl(string text)
        {
            int sayi;
            while (true)
            {
                Console.Write(text);
                string giris = Console.ReadLine();

                bool sonuc = int.TryParse(giris, out sayi);
                if (sonuc == true)
                {
                    return sayi;
                }
                Console.WriteLine("Hatalı giriş yapıldı tekrar deneyin.");
            }
        }
        static void Kurulum()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı: ");
            string filmAdi = Console.ReadLine();
            //Console.Write("Kapasite: ");
            //int kap =  int.Parse(Console.ReadLine());
            int kap = SayiAl("Kapasite: ");
            //Console.Write("Tam Bilet Fiyatı: ");
            //float tam = float.Parse(Console.ReadLine());
            float tam = SayiAl("Tam Bilet Fiyatı: ");
            //Console.Write("Yarım Bilet Fiyatı: ");
            //float yarim = float.Parse(Console.ReadLine());
            int yarim = SayiAl("Yarım Bilet Fiyatı: ");
            Snm = new Sinema(filmAdi, kap, tam, yarim);
        }




        static void Uygulama()
        {
            Kurulum();
            Menu();

            while (true)
            {
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSat();
                        break;
                    case "2":
                    case "R":
                        BiletIade();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static string SecimAl()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Seçiminiz: ");
            return Console.ReadLine().ToUpper();
        }

        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Bilet Sat(S)     ");
            Console.WriteLine("2 - Bilet İade(R)    ");
            Console.WriteLine("3 - Durum Bilgisi(D) ");
            Console.WriteLine("4 - Çıkış(X)         ");
        }


        static void BiletSat()
        {
            Console.WriteLine("Bilet Sat:             ");
            //Console.Write("Tam Bilet Adedi: ");
            //int tam = int.Parse(Console.ReadLine());
            int tam = SayiAl("Tam Bilet Adedi: ");

            //Console.Write();
            //int yarim = int.Parse(Console.ReadLine());
            int yarim = SayiAl("Yarım Bilet Adedi: ");

            Snm.BiletSat(tam, yarim);

        }

        static void BiletIade()
        {

            Console.WriteLine("Bilet Iade:             ");
            //Console.Write("Tam Bilet Adedi: ");
            //int tam = int.Parse(Console.ReadLine());
            int tam = SayiAl("Tam Bilet Adedi: ");

            //Console.Write();
            //int yarim = int.Parse(Console.ReadLine());
            int yarim = SayiAl("Yarım Bilet Adedi: ");

            //Snm.ToplamTamBiletAdedi += tam;
            //Snm.ToplamYarimBiletAdedi += yarim;
            Snm.BiletIade(tam, yarim);

        }

        static void DurumBilgisi()
        {
            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı : " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Snm.YarimBiletFiyati);
            Console.WriteLine("Toplam Tam Bilet Adedi: " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Toplam Yarım Bilet Adedi: " + Snm.ToplamYarimBiletAdedi);
            Console.WriteLine("Ciro: " + Snm.Ciro);
            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltukAdediGetir());

        }
    }
}
