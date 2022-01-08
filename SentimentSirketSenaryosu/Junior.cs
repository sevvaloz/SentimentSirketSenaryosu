using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentSirketSenaryosu
{
    public class Junior : CalisanKisi
    {
        public override void MaasHesapla()
        {
            base.MaasHesapla();
            MesaiUcreti = MesaiGunu * 300;
            Maas += MesaiUcreti;
        }
    }
}
