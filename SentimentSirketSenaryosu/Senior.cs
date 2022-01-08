using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentSirketSenaryosu
{
    public class Senior: CalisanKisi
    {
        public override void MaasHesapla()
        {
            base.MaasHesapla();
            Maas = Maas * 2;
            MesaiUcreti = MesaiGunu * 500;
            Maas += MesaiUcreti;
        }
    }
}
