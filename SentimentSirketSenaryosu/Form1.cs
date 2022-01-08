using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentSirketSenaryosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Sirket sirket = new Sirket();
            sirket.Ad = "Sentiment";

            Junior jun = new Junior();
            jun.Isim = "Ahmet Işık";
            jun.Tecrube = 2;
            jun.MesaiGunu = 3;
            jun.MaasHesapla();

            Senior sen = new Senior();
            sen.Isim = "Elif Karabağ";
            sen.Tecrube = 6;
            sen.MesaiGunu = 3;
            sen.MaasHesapla();

            Lead le = new Lead();
            le.Isim = "Turgay Kemal";
            le.MesaiGunu = 4;
            le.MaasHesapla();

            MessageBox.Show("Junior Maaşı: " + jun.Maas);
            MessageBox.Show("Senior Maaşı: " + sen.Maas);
            MessageBox.Show("Lead Maaşı: " + le.Maas);

            sirket.CalisanEkle(jun);
            sirket.CalisanEkle(sen);
            sirket.CalisanEkle(le);

            MessageBox.Show("Şirketin toplam maaş gideri: "+ sirket.CalisanlarinToplamMaasiniGoster());
            MessageBox.Show(sirket.CalisanlariListele());

        }
    }
}
