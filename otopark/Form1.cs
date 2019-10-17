using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            Arac arc = new Arac();
            arc.Plaka = txtPlaka.Text;
            arc.Tip = (Aractip)lstbxAractip.SelectedItem;
            arc.Kontak = tikKontak.Checked;
            arc.Abone = tikAbone.Checked;
            lstAraclar.Items.Add(arc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbxAractip.Items.Add(new Aractip { Adi=  "Otomobil(1)", Fiyat=  1 });
            lstbxAractip.Items.Add(new Aractip { Adi = "Arazi Aracı(2)", Fiyat = 2 });
            lstbxAractip.Items.Add(new Aractip { Adi = "Minibüs(3)", Fiyat = 3 });
            lstbxAractip.Items.Add(new Aractip { Adi = "Otobüs(4)", Fiyat = 4 });

        }

        private void LstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null) return;
            Arac secili = (Arac)lstAraclar.SelectedItem;
            secili.Cıkıs = DateTime.Now;
            lblPlaka.Text = secili.Plaka;
            lblSaat.Text = secili.Sure.ToString();
            lblUcret.Text = secili.Ucret.ToString("C2");
        }

        List<Arac> CıkısYapanlar = new List<Arac>();

        private void Cıkıs_Yap(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null) return;

            Arac secili = (Arac)lstAraclar.SelectedItem;
            CıkısYapanlar.Add(secili);
            lstAraclar.Items.Remove(secili);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Rapor form = new Rapor();
            decimal Total = 0;

            foreach (Arac item in CıkısYapanlar)
            {
                ListViewItem l = new ListViewItem();
                l.Text = item.Plaka;
                l.SubItems.Add(item.Tip.Adi);
                l.SubItems.Add(item.Abone?"Abone":"Abone Değil");
                l.SubItems.Add(item.Sure.ToString());
                l.SubItems.Add(item.Ucret.ToString("C2"));
                l.SubItems.Add(item.Giris.ToString());
                l.SubItems.Add(item.Cıkıs.ToString());
                form.listView1.Items.Add(l);
                Total += item.Ucret;

            }
            form.lblTplmArc.Text = CıkısYapanlar.Count.ToString();
            form.lblTplmUcret.Text = Total.ToString("C2");
            form.Show();
        }
    }
}
