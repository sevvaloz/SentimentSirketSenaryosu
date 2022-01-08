using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentSirketSenaryosu
{
    internal class Sirket
    {
        public string Ad { get; set; }
        public List<CalisanKisi> CalisanKisiler { get; set; }

        public Sirket()
        {
            CalisanKisiler = new List<CalisanKisi>();
        }

        public void CalisanEkle(CalisanKisi c)
        {
            CalisanKisiler.Add(c);
        }

        public string mesaj = "";
        public string CalisanlariListele()
        {
            foreach (CalisanKisi calisankisi in CalisanKisiler)
            {
                mesaj += calisankisi.Isim + "\n";
            }
            return mesaj;
        }


        public decimal toplam = 0;
        public decimal CalisanlarinToplamMaasiniGoster()
        {
            foreach (CalisanKisi calisankisi in CalisanKisiler)
            {
                toplam += calisankisi.Maas;
            }
            return toplam;
        }
    }

}
