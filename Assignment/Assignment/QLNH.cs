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
    public partial class QLNH : Form
    {
        private Bus bus;
        public QLNH()
        {
            InitializeComponent();
        }

        private void QLNH_Load(object sender, EventArgs e)
        {
            
        
            bus = new Bus();
            dataGridView1.DataSource = bus.datatable();
            dataGridView1.ClearSelection();
            Clean();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {

            try
            {
                String mahh = textMamh.Text;
                String tenhh = textTenMh.Text;
                String dvt = textDvt.Text;
                int soluong = Int32.Parse(textSoluong.Text);
                float gianhap = float.Parse(textGianhap.Text);
                float giaban = float.Parse(textGiaban.Text);
                HangHoa hh = new HangHoa(mahh, tenhh, dvt, soluong, gianhap, giaban);
                bus.insert(hh);
            }
            catch
            {
                MessageBox.Show("Nhap khoong hop le");
            }
         
     
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            int index=dataGridView1.SelectedRows[0].Index;
            bus.delete(index);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count <= 0)
                return;
                string mahh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DataRow row;
                int i;
                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    row = bus.select(i);

                    if (row[0].ToString() == mahh)
                    {
                        break;
                    }
                }
                row = bus.select(i);
                textMamh.Text = row[0].ToString();
                textTenMh.Text = row[1].ToString();
                textDvt.Text = row[2].ToString();
                textSoluong.Text = row[3].ToString();
                textGianhap.Text = row[4].ToString();
                textGiaban.Text = row[5].ToString();
         
        }
        private void buttThayDoi_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            int index = dataGridView1.SelectedRows[0].Index;
            DataRow row = bus.select(index);
            row[0] = textMamh.Text;
            row[1] = textTenMh.Text;
            row[2] = textDvt.Text;
            row[3] = textSoluong.Text;
            row[4] = textGianhap.Text;
            row[5] = textGiaban.Text;
            bus.update();
            Clean();
        }

        public void Clean()
        {
            textMamh.Text = textTenMh.Text = textDvt.Text = textSoluong.Text = textGianhap.Text = textGiaban.Text = "";
        }

        private void textMamh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textTenMh.Focus();
        }

        private void textTenMh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               textDvt.Focus();
        }

        private void textDvt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textSoluong.Focus();
        }

        private void textSoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textGianhap.Focus();
        }

        private void textGianhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textGiaban.Focus();
        }

        private void buttSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void textTimKiem_TextChanged(object sender, EventArgs e)
        {
          
              try
            {
              
                bus.search().DefaultView.RowFilter = " [MÃ MẶT HÀNG] like '%" + textTimKiem.Text + "%'";
                  
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clean();
            textMamh.Focus();
        }
    }
}