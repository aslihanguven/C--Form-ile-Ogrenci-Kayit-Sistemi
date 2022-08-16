using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Öğrenci_Kaydetmek
{
    public partial class rastgeleKayitOlustur : Form
    {
        public rastgeleKayitOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        sqliteClass _sqliteClass = new sqliteClass(dbPath: "okul.db", dbPass: "");

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> yeniKayit = new List<string>();

            int rastgele = 0;
            int rastgele2 = 0;
            int rastgele3 = 0;

            var satir = new ListViewItem();
            satir = listView1.Items.Add((listView1.Items.Count + 1).ToString());

            rastgele = new Random(Guid.NewGuid().GetHashCode()).Next(0, isimler.Items.Count);
            satir.SubItems.Add(isimler.Items[rastgele].ToString());

            rastgele = new Random(Guid.NewGuid().GetHashCode()).Next(11111, 99999);//int 10 basamak aldığı için ikiye böldük
            rastgele2 = new Random(Guid.NewGuid().GetHashCode()).Next(111111, 999999);
            satir.SubItems.Add(rastgele.ToString() + rastgele2.ToString());
            
            rastgele = new Random(Guid.NewGuid().GetHashCode()).Next(8,18); //yıl
            rastgele2 = new Random(Guid.NewGuid().GetHashCode()).Next(1,13); //ay
            rastgele3 = new Random(Guid.NewGuid().GetHashCode()).Next(1,31); //gün
            satir.SubItems.Add(rastgele3.ToString().PadLeft(2, '0') + "." + (rastgele2.ToString().PadLeft(2, '0') + DateTime.Now.AddYears(-rastgele).ToString(".yyyy")));

            rastgele = new Random(Guid.NewGuid().GetHashCode()).Next(0, sehirler.Items.Count);
            satir.SubItems.Add(sehirler.Items[rastgele].ToString());

            rastgele = new Random(Guid.NewGuid().GetHashCode()).Next(1, 13);
            rastgele2 = new Random(Guid.NewGuid().GetHashCode()).Next(0, 12);
            satir.SubItems.Add(rastgele.ToString() + "/" + "ABCDEFGHIJKL".Substring(rastgele2,1));

            rastgele = new Random(Guid.NewGuid().GetHashCode()).Next(11111, 99999);
            rastgele2 = new Random(Guid.NewGuid().GetHashCode()).Next(1111, 9999);
            satir.SubItems.Add("05" + rastgele.ToString() + rastgele2.ToString());

            for(int c=1; c < satir.SubItems.Count;c++) {
                if (Regex.IsMatch(satir.SubItems[c].Text, @"\d{2}\.\d{2}\.\d{4}"))
                {
                    try
                    {
                    yeniKayit.Add(DateTime.Parse(satir.SubItems[c].Text).ToString("yyyy-MM-dd"));//28 şubatta hata aldığımız için tryı kullandık ve hata verenlerde bugünün tarihini at dedik
                    }
                    catch (Exception)
                    {
                        yeniKayit.Add(DateTime.Now.ToString("yyyy-MM-dd"));
                    
                       
                    }
                    
                }
                else
                {
                    yeniKayit.Add(satir.SubItems[c].Text);
                }
            }

            if (_sqliteClass.insertRow("ogrenciler", yeniKayit.ToArray()))
            {
                satir.BackColor = Color.LightGreen;
            }
            else
            {
                satir.BackColor = Color.LightPink;
            }

            listView1.TopItem = satir;// aşağı kaydırmayı yapıyor

            if (listView1.Items.Count >= 100) { timer1.Enabled = false; }
        }

        
    }
}
