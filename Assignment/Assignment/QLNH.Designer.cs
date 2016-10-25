namespace Assignment
{
    partial class QLNH
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textGianhap = new System.Windows.Forms.TextBox();
            this.textDvt = new System.Windows.Forms.TextBox();
            this.textTenMh = new System.Windows.Forms.TextBox();
            this.textMamh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttSearch = new System.Windows.Forms.Button();
            this.textTimKiem = new System.Windows.Forms.TextBox();
            this.textGiaban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.buttDelete = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttThayDoi = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textGianhap
            // 
            this.textGianhap.Location = new System.Drawing.Point(129, 112);
            this.textGianhap.Name = "textGianhap";
            this.textGianhap.Size = new System.Drawing.Size(100, 20);
            this.textGianhap.TabIndex = 5;
            this.textGianhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textGianhap_KeyDown);
            // 
            // textDvt
            // 
            this.textDvt.Location = new System.Drawing.Point(129, 82);
            this.textDvt.Name = "textDvt";
            this.textDvt.Size = new System.Drawing.Size(100, 20);
            this.textDvt.TabIndex = 3;
            this.textDvt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDvt_KeyDown);
            // 
            // textTenMh
            // 
            this.textTenMh.Location = new System.Drawing.Point(129, 56);
            this.textTenMh.Name = "textTenMh";
            this.textTenMh.Size = new System.Drawing.Size(228, 20);
            this.textTenMh.TabIndex = 2;
            this.textTenMh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTenMh_KeyDown);
            // 
            // textMamh
            // 
            this.textMamh.Location = new System.Drawing.Point(129, 30);
            this.textMamh.Name = "textMamh";
            this.textMamh.Size = new System.Drawing.Size(100, 20);
            this.textMamh.TabIndex = 1;
            this.textMamh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMamh_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gía nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên mặt hàng";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sắp xếp theo số lượng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttSearch
            // 
            this.buttSearch.Location = new System.Drawing.Point(96, 65);
            this.buttSearch.Name = "buttSearch";
            this.buttSearch.Size = new System.Drawing.Size(75, 23);
            this.buttSearch.TabIndex = 2;
            this.buttSearch.Text = "Tìm kiếm";
            this.buttSearch.UseVisualStyleBackColor = true;
            this.buttSearch.Click += new System.EventHandler(this.buttSearch_Click);
            // 
            // textTimKiem
            // 
            this.textTimKiem.Location = new System.Drawing.Point(108, 25);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(282, 20);
            this.textTimKiem.TabIndex = 1;
            this.textTimKiem.TextChanged += new System.EventHandler(this.textTimKiem_TextChanged);
            // 
            // textGiaban
            // 
            this.textGiaban.Location = new System.Drawing.Point(129, 146);
            this.textGiaban.Name = "textGiaban";
            this.textGiaban.Size = new System.Drawing.Size(100, 20);
            this.textGiaban.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gía bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên mặt hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(313, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Làm mới";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttDelete
            // 
            this.buttDelete.Location = new System.Drawing.Point(120, 29);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(75, 23);
            this.buttDelete.TabIndex = 1;
            this.buttDelete.Text = "Xóa";
            this.buttDelete.UseVisualStyleBackColor = true;
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(22, 29);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttSearch);
            this.groupBox3.Controls.Add(this.textTimKiem);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(-6, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 108);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSoluong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textGiaban);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textGianhap);
            this.groupBox2.Controls.Add(this.textDvt);
            this.groupBox2.Controls.Add(this.textTenMh);
            this.groupBox2.Controls.Add(this.textMamh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(-6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 180);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng nhập";
            // 
            // textSoluong
            // 
            this.textSoluong.Location = new System.Drawing.Point(320, 115);
            this.textSoluong.Name = "textSoluong";
            this.textSoluong.Size = new System.Drawing.Size(29, 20);
            this.textSoluong.TabIndex = 4;
            this.textSoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSoluong_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(396, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 449);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttThayDoi
            // 
            this.buttThayDoi.Location = new System.Drawing.Point(214, 29);
            this.buttThayDoi.Name = "buttThayDoi";
            this.buttThayDoi.Size = new System.Drawing.Size(75, 23);
            this.buttThayDoi.TabIndex = 2;
            this.buttThayDoi.Text = "Thay đổi";
            this.buttThayDoi.UseVisualStyleBackColor = true;
            this.buttThayDoi.Click += new System.EventHandler(this.buttThayDoi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.buttThayDoi);
            this.groupBox4.Controls.Add(this.buttDelete);
            this.groupBox4.Controls.Add(this.butAdd);
            this.groupBox4.Location = new System.Drawing.Point(-10, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 68);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // QLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "QLNH";
            this.Text = "QLBH";
            this.Load += new System.EventHandler(this.QLNH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textGianhap;
        private System.Windows.Forms.TextBox textDvt;
        private System.Windows.Forms.TextBox textTenMh;
        private System.Windows.Forms.TextBox textMamh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttSearch;
        private System.Windows.Forms.TextBox textTimKiem;
        private System.Windows.Forms.TextBox textGiaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttDelete;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttThayDoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoluong;

   

    }
}