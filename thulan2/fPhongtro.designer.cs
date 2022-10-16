namespace quanliphongtro
{
    partial class fPhongtro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSophong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSotang = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTTPhongtro = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblQLPT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.grbTTPhongtro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Location = new System.Drawing.Point(17, 40);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(65, 16);
            this.lblSophong.TabIndex = 1;
            this.lblSophong.Text = "Số phòng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 43);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colTang,
            this.colGia,
            this.colTrangthai,
            this.colKhachhang});
            this.dgvPhong.Location = new System.Drawing.Point(393, 92);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.Size = new System.Drawing.Size(787, 462);
            this.dgvPhong.TabIndex = 3;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên phòng";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colTang
            // 
            this.colTang.HeaderText = "Số tầng";
            this.colTang.MinimumWidth = 8;
            this.colTang.Name = "colTang";
            this.colTang.Width = 150;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            this.colGia.Width = 150;
            // 
            // colTrangthai
            // 
            this.colTrangthai.HeaderText = "Trạng thái";
            this.colTrangthai.MinimumWidth = 8;
            this.colTrangthai.Name = "colTrangthai";
            this.colTrangthai.Width = 150;
            // 
            // colKhachhang
            // 
            this.colKhachhang.HeaderText = "Khách hàng";
            this.colKhachhang.MinimumWidth = 8;
            this.colKhachhang.Name = "colKhachhang";
            this.colKhachhang.Width = 150;
            // 
            // lblSotang
            // 
            this.lblSotang.AutoSize = true;
            this.lblSotang.Location = new System.Drawing.Point(22, 79);
            this.lblSotang.Name = "lblSotang";
            this.lblSotang.Size = new System.Drawing.Size(53, 16);
            this.lblSotang.TabIndex = 1;
            this.lblSotang.Text = "Số tầng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(42, 121);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(28, 16);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Location = new System.Drawing.Point(15, 165);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(67, 16);
            this.lblTrangthai.TabIndex = 1;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(15, 207);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 22);
            this.textBox5.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(227, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 43);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(176, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 46);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(116, 13);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 43);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(63, 73);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(83, 46);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1094, 571);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 50);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbTTPhongtro
            // 
            this.grbTTPhongtro.BackColor = System.Drawing.Color.Gainsboro;
            this.grbTTPhongtro.Controls.Add(this.comboBox1);
            this.grbTTPhongtro.Controls.Add(this.lblSophong);
            this.grbTTPhongtro.Controls.Add(this.textBox1);
            this.grbTTPhongtro.Controls.Add(this.lblSotang);
            this.grbTTPhongtro.Controls.Add(this.textBox2);
            this.grbTTPhongtro.Controls.Add(this.lblGia);
            this.grbTTPhongtro.Controls.Add(this.textBox3);
            this.grbTTPhongtro.Controls.Add(this.lblTrangthai);
            this.grbTTPhongtro.Controls.Add(this.textBox5);
            this.grbTTPhongtro.Controls.Add(this.lblTenKhachHang);
            this.grbTTPhongtro.Location = new System.Drawing.Point(16, 92);
            this.grbTTPhongtro.Name = "grbTTPhongtro";
            this.grbTTPhongtro.Size = new System.Drawing.Size(355, 258);
            this.grbTTPhongtro.TabIndex = 11;
            this.grbTTPhongtro.TabStop = false;
            this.grbTTPhongtro.Text = "Thông tin phòng ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Location = new System.Drawing.Point(32, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 198);
            this.panel1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(130, 139);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(76, 42);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lblQLPT
            // 
            this.lblQLPT.AutoSize = true;
            this.lblQLPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPT.ForeColor = System.Drawing.Color.Brown;
            this.lblQLPT.Location = new System.Drawing.Point(501, 22);
            this.lblQLPT.Name = "lblQLPT";
            this.lblQLPT.Size = new System.Drawing.Size(276, 29);
            this.lblQLPT.TabIndex = 13;
            this.lblQLPT.Text = "QUẢN LÍ PHÒNG TRỌ";
            // 
            // fPhongtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1194, 656);
            this.Controls.Add(this.lblQLPT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbTTPhongtro);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvPhong);
            this.Name = "fPhongtro";
            this.Text = "fPhongtro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.grbTTPhongtro.ResumeLayout(false);
            this.grbTTPhongtro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblSotang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachhang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbTTPhongtro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblQLPT;
    }
}