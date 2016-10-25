namespace Assignment
{
    partial class QLBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.textTenHang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numCk = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textTraLai = new System.Windows.Forms.TextBox();
            this.textTienKhach = new System.Windows.Forms.TextBox();
            this.textTongCong = new System.Windows.Forms.TextBox();
            this.textCk = new System.Windows.Forms.TextBox();
            this.textTinhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.ngayLap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCk)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textSoLuong);
            this.groupBox1.Controls.Add(this.textTenHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên hàng";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(72, 45);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(36, 20);
            this.textSoLuong.TabIndex = 2;
            this.textSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSoLuong_KeyDown);
            // 
            // textTenHang
            // 
            this.textTenHang.AutoCompleteCustomSource.AddRange(new string[] {
            "C2",
            "DT",
            "DT01    ",
            "DT02      ",
            "DT03      ",
            "k",
            "minh1    ",
            "PAN",
            "s"});
            this.textTenHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textTenHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textTenHang.Location = new System.Drawing.Point(72, 19);
            this.textTenHang.Name = "textTenHang";
            this.textTenHang.Size = new System.Drawing.Size(242, 20);
            this.textTenHang.TabIndex = 1;
            this.textTenHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTenHang_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 305);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 286);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã mặt hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên mặt hàng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn vị tính";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 53;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gía Bán";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành Tiền";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 97;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numCk);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textTraLai);
            this.groupBox3.Controls.Add(this.textTienKhach);
            this.groupBox3.Controls.Add(this.textTongCong);
            this.groupBox3.Controls.Add(this.textCk);
            this.groupBox3.Controls.Add(this.textTinhTien);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(338, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 164);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // numCk
            // 
            this.numCk.Location = new System.Drawing.Point(104, 47);
            this.numCk.Name = "numCk";
            this.numCk.Size = new System.Drawing.Size(46, 20);
            this.numCk.TabIndex = 8;
            this.numCk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCk.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "%";
            // 
            // textTraLai
            // 
            this.textTraLai.Location = new System.Drawing.Point(195, 126);
            this.textTraLai.Name = "textTraLai";
            this.textTraLai.Size = new System.Drawing.Size(359, 20);
            this.textTraLai.TabIndex = 5;
            this.textTraLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTienKhach
            // 
            this.textTienKhach.Location = new System.Drawing.Point(195, 100);
            this.textTienKhach.Name = "textTienKhach";
            this.textTienKhach.Size = new System.Drawing.Size(359, 20);
            this.textTienKhach.TabIndex = 5;
            this.textTienKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTienKhach.TextChanged += new System.EventHandler(this.textTienKhach_TextChanged);
            // 
            // textTongCong
            // 
            this.textTongCong.Location = new System.Drawing.Point(195, 74);
            this.textTongCong.Name = "textTongCong";
            this.textTongCong.ReadOnly = true;
            this.textTongCong.Size = new System.Drawing.Size(359, 20);
            this.textTongCong.TabIndex = 5;
            this.textTongCong.Text = "0";
            this.textTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textCk
            // 
            this.textCk.Location = new System.Drawing.Point(195, 49);
            this.textCk.Name = "textCk";
            this.textCk.Size = new System.Drawing.Size(359, 20);
            this.textCk.TabIndex = 5;
            this.textCk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCk.TextChanged += new System.EventHandler(this.chietKhau);
            // 
            // textTinhTien
            // 
            this.textTinhTien.Location = new System.Drawing.Point(195, 22);
            this.textTinhTien.Name = "textTinhTien";
            this.textTinhTien.ReadOnly = true;
            this.textTinhTien.Size = new System.Drawing.Size(359, 20);
            this.textTinhTien.TabIndex = 4;
            this.textTinhTien.Text = "0";
            this.textTinhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trả lại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền khách đưa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chiết khấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng cộng";
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(9, 123);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(90, 23);
            this.buttSave.TabIndex = 1;
            this.buttSave.Text = "Lưu hóa đơn";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.buttSave);
            this.groupBox4.Location = new System.Drawing.Point(12, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 155);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Xem Báo cáo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày giờ bán:";
            // 
            // ngayLap
            // 
            this.ngayLap.AutoSize = true;
            this.ngayLap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayLap.Location = new System.Drawing.Point(100, 306);
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.Size = new System.Drawing.Size(44, 17);
            this.ngayLap.TabIndex = 4;
            this.ngayLap.Text = "label9";
            // 
            // QLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 493);
            this.Controls.Add(this.ngayLap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "QLBH";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QLBH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCk)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textTenHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTraLai;
        private System.Windows.Forms.TextBox textTienKhach;
        private System.Windows.Forms.TextBox textTongCong;
        private System.Windows.Forms.TextBox textCk;
        private System.Windows.Forms.TextBox textTinhTien;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.NumericUpDown numCk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ngayLap;
    }
}

