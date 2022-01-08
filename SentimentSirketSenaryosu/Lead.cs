using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentSirketSenaryosu
{
    public class Lead:  CalisanKisi
    {
        public override void MaasHesapla()
        {
            base.MaasHesapla();
            Maas = Maas * 4;
            MesaiUcreti = MesaiGunu * 700;
            Maas += MesaiUcreti; 
        }
    }
}
