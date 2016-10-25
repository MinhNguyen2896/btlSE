using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.BUS;
using QLBH.DTO;
namespace Assignment
{
    public partial class QLBH : Form
    {
        private BusHd bushd;
        DataTable table;
        int stt = 1;
        int hd = 0;
        public QLBH()
        {
            InitializeComponent();
        }

        private void textTenHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textSoLuong.Focus();
            }

        }

        private void textSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dieukien = "WHERE [MÃ MẶT HÀNG] like '%"+textTenHang.Text+"%'";
                table = bushd.layDuLieu(dieukien);
                 {
                     
                     DataRow dr = table.Rows[table.Rows.Count - 1];
                     ListViewItem listitem = new ListViewItem((stt).ToString());
                     bool bosung = false;
                     for (int i = 0; i<  listView1.Items.Count; i++)
                     {
                        if (listView1.Items[i].SubItems[1].Text.Trim() == textTenHang.Text.Trim())
                        {
                            listView1.Items[i].SubItems[4].Text = (Int32.Parse(listView1.Items[i].SubItems[4].Text) + Int32.Parse(textSoLuong.Text)).ToString("G");
                            listView1.Items[i].SubItems[6].Text = (Int32.Parse(dr[3].ToString()) * Int32.Parse(listView1.Items[i].SubItems[4].Text)).ToString("G");
                            bosung = true;
                        }
                     }
                     if (!bosung)
                     {
                         listitem.SubItems.Add(dr[0].ToString());
                         listitem.SubItems.Add(dr[1].ToString());
                         listitem.SubItems.Add(dr[2].ToString());
                         listitem.SubItems.Add(textSoLuong.Text);
                         listitem.SubItems.Add(dr[3].ToString());
                         listitem.SubItems.Add((Int32.Parse(dr[3].ToString()) * Int32.Parse(textSoLuong.Text)).ToString());
                         listView1.Items.Add(listitem);
                     }
                     tinhTien();

                     clean();
                     textTenHang.Focus();
                 }
                 stt++;
            }
        }

        public void clean()
        {
            textTenHang.Text = textSoLuong.Text = "";
            numCk.Value = 0;
        }
        public int tinhTien()
         {
            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum += Int32.Parse(listView1.Items[i].SubItems[6].Text);
                textTinhTien.Text = sum.ToString();
                textTongCong.Text = sum.ToString();
            }
            return sum;
        }

        private void QLBH_Load(object sender, EventArgs e)
        {
            bushd = new BusHd();
            table = new DataTable();
            listView1.FullRowSelect = true;
            ngayLap.Text = DateTime.Now.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal tongCong = 0;
            tongCong =tinhTien()- (tinhTien() * numCk.Value/100);
            textTongCong.Text = tongCong.ToString();
        }

        private void textTienKhach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textTraLai.Text = (Int32.Parse(textTienKhach.Text) - Int32.Parse(textTongCong.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Chua nhap");
                textTraLai.Text = "0";
            }
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            hd++;
            string maHD="HDXX";
             string mahd= maHD.Replace("XX", hd.ToString());
             HoaDon hdon = new HoaDon(mahd, Convert.ToDateTime(ngayLap.Text));
             string s = bushd.saveDuLieu(hdon).ToString();
             if (textCk.Text != "")
             {
                 float chieukhau = (float.Parse(textCk.Text) * float.Parse(textTongCong.Text) / 100);
             }

            
          for( int item=0;item<listView1.Items.Count;item++)
          {
              string maMh=listView1.Items[item].SubItems[1].Text;
              int soLuong=Int32.Parse(listView1.Items[item].SubItems[4].Text);
              Int32 thanhTien=Int32.Parse(listView1.Items[item].SubItems[6].Text);
              dataGridView1.DataSource = bushd.saveDuLieu(hdon);
              MessageBox.Show(s);
          }
        }

        private void chietKhau(object sender, EventArgs e)
        {
            decimal tongCong = 0;
            try
            {
                tongCong = tinhTien() - Int32.Parse(textCk.Text);
                if (tongCong >= 0)
                    textTongCong.Text = tongCong.ToString();
                else
                {
                    textCk.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("chua nhap");
            }
        }
    }
}
