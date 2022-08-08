using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinema_G022
{
    class Sinema
    {
        public string FilmAdi { get; set; }
        public int Kapasite { get; }
        public float TamBiletFiyati { get; }
        public float YarimBiletFiyati { get; }
        public int ToplamTamBiletAdedi { get; private set; }
        public int ToplamYarimBiletAdedi { get; private set; }
        public float Ciro
        {
            get
            {
                return this.ToplamTamBiletAdedi * this.TamBiletFiyati + this.ToplamYarimBiletAdedi * this.YarimBiletFiyati;
            }         
        }


        public Sinema(string filmAdi, int kapasite, float tamBiletFiyati, float yarimBiletFiyati)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tamBiletFiyati;
            this.YarimBiletFiyati = yarimBiletFiyati;
        }

        public void BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {
            //satılacak bilet kalmadıysa bu işlem gerçekleştirilemesin
            //max kaç bilet satılabileceğini de ekrana yazsın

            if (tamBiletAdedi + yarimBiletAdedi <= BosKoltukAdediGetir())
            {
                this.ToplamTamBiletAdedi = this.ToplamTamBiletAdedi + tamBiletAdedi;
                this.ToplamYarimBiletAdedi += yarimBiletAdedi;
                //CiroHesapla()
                Console.Write("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                Console.WriteLine("Satılabilecek maksimum bilet adedi: " + BosKoltukAdediGetir());
            }
        }


        public void BiletIade(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (tamBiletAdedi <= this.ToplamTamBiletAdedi && yarimBiletAdedi <= this.ToplamYarimBiletAdedi)
            {
                this.ToplamTamBiletAdedi = this.ToplamTamBiletAdedi - tamBiletAdedi;
                this.ToplamYarimBiletAdedi -= yarimBiletAdedi;
                //CiroHesapla()
                Console.Write("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                Console.WriteLine("Satılmış bişet adedinden fazla iade adedi girildi.");
            }
        }


        private void CiroHesapla()
        {
           // this.Ciro = this.ToplamTamBiletAdedi * this.TamBiletFiyati + this.ToplamYarimBiletAdedi * this.YarimBiletFiyati;
        }

        public int BosKoltukAdediGetir()
        {
            int bosKoltuk = this.Kapasite - this.ToplamTamBiletAdedi - this.ToplamYarimBiletAdedi;
            return bosKoltuk;
        }
    }
}
