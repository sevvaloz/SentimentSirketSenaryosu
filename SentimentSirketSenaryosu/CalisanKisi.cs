using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentSirketSenaryosu
{
    public abstract class CalisanKisi
    {
        public const decimal ASGARIUCRET = 4250;
        public int MesaiGunu { get; set; }
        public decimal MesaiUcreti { get; set; }
        public string Isim { get; set; }
        public decimal Maas { get; set; }
        public int Tecrube { get; set; }
        public virtual void MaasHesapla()
        {
            Maas = ASGARIUCRET * 2;
        }
    }
}
