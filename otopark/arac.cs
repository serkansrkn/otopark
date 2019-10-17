using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark
{
    class Arac
    {
        public Arac()
        {
            Giris = DateTime.Now;
        }
        public string Plaka { get; set; }
        public Aractip Tip { get; set; }
        public bool Kontak { get; set; }
        public bool Abone { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cıkıs { get; set; }
        public int Sure
        {
            get
            {
                TimeSpan fark = Cıkıs - Giris;
                fark=fark.Add(TimeSpan.FromHours(1));

                return (int)fark.TotalHours;
            }
        }
        public decimal Ucret
        {
            get
            {
                decimal toplam = Tip.Fiyat * Sure;
                if(Abone)
                {
                    toplam *= 0.8m;
                }
                return toplam;
            }
        }
        public override string ToString()
        {
            string metinAbone = Abone? "Abone" : "Abone Değil";
            string metinKontak = Kontak? "Kontak var" : "Kontak yok";
            return string.Format("{0} - {1} - {2} - {3}",Plaka,Tip.Adi,metinKontak,metinAbone);
        }
    }

    class Aractip
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return Adi;
        }

    }
}
