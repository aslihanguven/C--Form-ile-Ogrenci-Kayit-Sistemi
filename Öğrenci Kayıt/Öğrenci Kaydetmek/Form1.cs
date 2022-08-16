using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Mono.Data.Sqlite;

namespace Öğrenci_Kaydetmek
{
    public partial class Form1 : Form
    {

        //----------------------[ İcon İşlemleri ]-----------------------
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }
        //------------------------------------------------------------



        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            dateTimePicker1.ResetText();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            numericUpDown1.Value = 1m;  //bana 1 tane MDF aL
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as MaskedTextBox).SelectionStart = 0;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (!Regex.IsMatch(textBox1.Text, @"\w+\s\w+"))
            //{
            //    textBox1.BackColor = Color.LightPink;
            //    textBox1.Refresh();
            //    System.Threading.Thread.Sleep(500); //0.5 sn --> milisaniye
            //    textBox1.BackColor = Color.White;
            //    textBox1.Refresh();
            //    textBox1.Select();
            //}
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(maskedTextBox1.Text, @"\d{11}"))
            {
                {
                    maskedTextBox1.BackColor = Color.LightPink;
                    maskedTextBox1.Refresh();
                    System.Threading.Thread.Sleep(500); //0.5 sn --> milisaniye
                    maskedTextBox1.BackColor = Color.White;
                    maskedTextBox1.Refresh();
                    maskedTextBox1.Select();
                }
            }
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(maskedTextBox2.Text, @"\d{10}"))
            {
                {
                    maskedTextBox2.BackColor = Color.LightPink;
                    maskedTextBox2.Refresh();
                    System.Threading.Thread.Sleep(500); //0.5 sn --> milisaniye
                    maskedTextBox2.BackColor = Color.White;
                    maskedTextBox2.Refresh();
                    maskedTextBox2.Select();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newRow = new string[] {
                        textBox1.Text,
                        maskedTextBox1.Text,
                        dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        comboBox1.Text,
                        numericUpDown1.Value.ToString() + "/" + comboBox2.Text,
                        maskedTextBox2.Text
            };
            
            if (button2.Text == "EKLE")
            {
                if (_sqliteClass.insertRow("ogrenciler", newRow)) 
                { 
                    dataGridView1.Rows.Add(newRow);
                }                
            }
            else if (button2.Text == "GÜNCELLE")
            {
                int id = int.Parse(button2.Tag.ToString());

                if (_sqliteClass.updateRow("ogrenciler", newRow, "rowid=" + dataGridView1.Rows[id].Tag.ToString()))
                {
                    var secilmisSatir = dataGridView1.Rows[id];
                    for (int i = 0; i < newRow.Length; i++)
                    {
                        secilmisSatir.Cells[i].Value = newRow[i];
                    }
                }
            }

            button2.Tag = null;
            button1.PerformClick();
            button2.Text = "EKLE";
            dataGridView1.ClearSelection();

            //List<object> satir =  new List<object>();  //List koleksiyonu
            //satir.Add(textBox1.Text);
            //satir.Add(maskedTextBox1.Text);
            //satir.Add(dateTimePicker1.Value.ToString("dd.MM.yyyy"));
            //satir.Add(comboBox1.Text);
            //satir.Add(numericUpDown1.Value.ToString() + "/" + comboBox2.Text);
            //satir.Add(maskedTextBox2.Text);

            //dataGridView1.Rows.Add(satir.ToArray());

        }

        private void seçileniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Tag.ToString());
                if (_sqliteClass.deleteRow("ogrenciler", id))
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    button2.Tag = null;
                    button2.Text = "EKLE";
                    button1.PerformClick();
                }   
                
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (button2.Tag == null || e.RowIndex.ToString() != button2.Tag.ToString())
            {
                var secilmisSatir = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = secilmisSatir.Cells[0].Value.ToString();
                maskedTextBox1.Text = secilmisSatir.Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(secilmisSatir.Cells[2].Value.ToString());
                comboBox1.SelectedItem = secilmisSatir.Cells[3].Value.ToString();
                numericUpDown1.Value = decimal.Parse(secilmisSatir.Cells[4].Value.ToString().Split('/')[0]);
                comboBox2.SelectedItem = secilmisSatir.Cells[4].Value.ToString().Split('/')[1];
                maskedTextBox2.Text = secilmisSatir.Cells[5].Value.ToString();

                button2.Tag = e.RowIndex.ToString();
                button2.Text = "GÜNCELLE";
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //List<Color> renkler = new List<Color>();

            //foreach (KnownColor renk in Enum.GetValues(typeof(KnownColor)))
            //{
            //    if (Color.FromKnownColor(renk).Name.StartsWith("Light"))
            //    {
            //        renkler.Add(Color.FromKnownColor(renk));
            //        if (renkler.Count >= 12) { break; }
            //    }
            //}

            //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = renkler[int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Split('/')[0]) - 1];

        }

        sqliteClass _sqliteClass = new sqliteClass(dbPath: "okul.db", dbPass: "");

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add(new object[] { "", "", "", "", "", "" });

            dataGridView1.Rows.Clear();

            dataGridView1.Rows.AddRange(_sqliteClass.getAllRecords("ogrenciler"));

        }

        private void dataGridView2_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridView1.Columns[e.Column.Index].Width = e.Column.Width;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.BeginEdit(true); //Tıkladığım hücrede editlemeyi aktif et
        }

        private void dataGridView_TextChanged(object sender, EventArgs e)
        {
            var hucre = (DataGridViewTextBoxEditingControl)sender;

            if (hucre.Text.Length > 2)
            { //filtreleme için en az 3 karakter girilmiş olsun ki işlem kasmasın!

                string aranan = hucre.Text;

                for (int s = 0; s < dataGridView1.Rows.Count; s++)
                {
                    if (!dataGridView1.Rows[s].Cells[dataGridView2.CurrentCell.ColumnIndex].Value.ToString().Contains(aranan))
                    {
                        dataGridView1.Rows[s].Visible = false; //satırı gizle
                    }
                }

            }
            else
            { //girilen filtre metini 2 den küçükse hepsini göster
                for (int s = 0; s < dataGridView1.Rows.Count; s++)
                {
                    dataGridView1.Rows[s].Visible = true; //satırı göster
                }
            }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.TextChanged += new EventHandler(dataGridView_TextChanged);
        }


        Rectangle dragBoxFromMouseDown;
        int rowIndexFromMouseDown = -1;
        int rowIndexOfItemUnderMouseToDrop = -1;
        int rowIndex = -1;
        bool ctrl = false;

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ctrl) { return; }

            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                catch (Exception) { }

                rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                try
                {
                    dataGridView1.Rows[rowIndex].Selected = false;
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                }
                catch (Exception) { }

                if (rowIndex > rowIndexFromMouseDown)
                {
                    this.Cursor = CreateCursor(new Bitmap(Properties.Resources.down), 5, 5);
                }
                else if (rowIndex < rowIndexFromMouseDown)
                {
                    this.Cursor = CreateCursor(new Bitmap(Properties.Resources.up), 5, 5);
                }
                else if (rowIndex == rowIndexFromMouseDown)
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ctrl) { return; }

            rowIndexFromMouseDown = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dragBoxFromMouseDown = Rectangle.Empty;
            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ctrl) { return; }

            this.Cursor = Cursors.Default;
            rowIndexOfItemUnderMouseToDrop = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            try
            {
                DataGridViewRow rowToMove = dataGridView1.Rows[rowIndexOfItemUnderMouseToDrop];
                dataGridView1.Rows.RemoveAt(rowIndexOfItemUnderMouseToDrop);
                dataGridView1.Rows.Insert(rowIndexFromMouseDown, rowToMove);
            }
            catch (Exception) { }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrl = false;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) { ctrl = true; }
            else { ctrl = false; }
        }

    }
}
