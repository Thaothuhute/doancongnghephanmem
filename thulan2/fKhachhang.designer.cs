namespace quanliphongtro
{
    partial class fKhachhang
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
            this.components = new System.ComponentModel.Container();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.cbbSP = new System.Windows.Forms.ComboBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.chbKhac = new System.Windows.Forms.CheckBox();
            this.chbNu = new System.Windows.Forms.CheckBox();
            this.chbNam = new System.Windows.Forms.CheckBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblSophong = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.qlyphongtroDataSet = new thulan2.QlyphongtroDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new thulan2.QlyphongtroDataSetTableAdapters.KHACHHANGTableAdapter();
            this.grbTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyphongtroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTKH
            // 
            this.grbTTKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTTKH.BackColor = System.Drawing.Color.RosyBrown;
            this.grbTTKH.Controls.Add(this.cbbSP);
            this.grbTTKH.Controls.Add(this.btnImage);
            this.grbTTKH.Controls.Add(this.chbKhac);
            this.grbTTKH.Controls.Add(this.chbNu);
            this.grbTTKH.Controls.Add(this.chbNam);
            this.grbTTKH.Controls.Add(this.txtSDT);
            this.grbTTKH.Controls.Add(this.txtCMND);
            this.grbTTKH.Controls.Add(this.txtTenKhachHang);
            this.grbTTKH.Controls.Add(this.lblGioitinh);
            this.grbTTKH.Controls.Add(this.lblSophong);
            this.grbTTKH.Controls.Add(this.lblSDT);
            this.grbTTKH.Controls.Add(this.lblCMND);
            this.grbTTKH.Controls.Add(this.lblTenKhachHang);
            this.grbTTKH.Controls.Add(this.pictureBox1);
            this.grbTTKH.Location = new System.Drawing.Point(112, 10);
            this.grbTTKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTKH.Size = new System.Drawing.Size(1020, 171);
            this.grbTTKH.TabIndex = 0;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin khách hàng";
            // 
            // cbbSP
            // 
            this.cbbSP.FormattingEnabled = true;
            this.cbbSP.Location = new System.Drawing.Point(550, 38);
            this.cbbSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSP.Name = "cbbSP";
            this.cbbSP.Size = new System.Drawing.Size(108, 24);
            this.cbbSP.TabIndex = 5;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(888, 139);
            this.btnImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(80, 27);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "IMAGE";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // chbKhac
            // 
            this.chbKhac.AutoSize = true;
            this.chbKhac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbKhac.Location = new System.Drawing.Point(297, 142);
            this.chbKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbKhac.Name = "chbKhac";
            this.chbKhac.Size = new System.Drawing.Size(59, 20);
            this.chbKhac.TabIndex = 3;
            this.chbKhac.Text = "Khác";
            this.chbKhac.UseVisualStyleBackColor = true;
            // 
            // chbNu
            // 
            this.chbNu.AutoSize = true;
            this.chbNu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbNu.Location = new System.Drawing.Point(234, 142);
            this.chbNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbNu.Name = "chbNu";
            this.chbNu.Size = new System.Drawing.Size(46, 20);
            this.chbNu.TabIndex = 3;
            this.chbNu.Text = "Nữ";
            this.chbNu.UseVisualStyleBackColor = true;
            // 
            // chbNam
            // 
            this.chbNam.AutoSize = true;
            this.chbNam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbNam.Location = new System.Drawing.Point(156, 142);
            this.chbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbNam.Name = "chbNam";
            this.chbNam.Size = new System.Drawing.Size(58, 20);
            this.chbNam.TabIndex = 3;
            this.chbNam.Text = "Nam";
            this.chbNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(156, 104);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(177, 22);
            this.txtSDT.TabIndex = 2;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(156, 71);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(177, 22);
            this.txtCMND.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(156, 38);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(177, 22);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.BackColor = System.Drawing.Color.DarkGray;
            this.lblGioitinh.Location = new System.Drawing.Point(76, 145);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioitinh.TabIndex = 1;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.BackColor = System.Drawing.Color.DarkGray;
            this.lblSophong.Location = new System.Drawing.Point(414, 44);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(65, 16);
            this.lblSophong.TabIndex = 1;
            this.lblSophong.Text = "Số phòng";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.DarkGray;
            this.lblSDT.Location = new System.Drawing.Point(99, 109);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(34, 16);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "SĐT";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.DarkGray;
            this.lblCMND.Location = new System.Drawing.Point(44, 74);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(88, 16);
            this.lblCMND.TabIndex = 1;
            this.lblCMND.Text = "CMND/CCCD";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.BackColor = System.Drawing.Color.DarkGray;
            this.lblTenKhachHang.Location = new System.Drawing.Point(28, 38);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OldLace;
            this.pictureBox1.Location = new System.Drawing.Point(868, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(731, 193);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(291, 5);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 29);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(163, 5);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(102, 29);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(37, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 29);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKhachhang.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenKH,
            this.colCMND,
            this.colSDT,
            this.colGioitinh,
            this.colSP});
            this.dgvKhachhang.Location = new System.Drawing.Point(114, 246);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersWidth = 62;
            this.dgvKhachhang.RowTemplate.Height = 28;
            this.dgvKhachhang.Size = new System.Drawing.Size(1017, 195);
            this.dgvKhachhang.TabIndex = 2;
            this.dgvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellContentClick);
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.MinimumWidth = 8;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Width = 190;
            // 
            // colCMND
            // 
            this.colCMND.HeaderText = "CMND/CCCD";
            this.colCMND.MinimumWidth = 8;
            this.colCMND.Name = "colCMND";
            this.colCMND.Width = 150;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SDT";
            this.colSDT.MinimumWidth = 8;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 150;
            // 
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.MinimumWidth = 8;
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Width = 150;
            // 
            // colSP
            // 
            this.colSP.HeaderText = "Số phòng";
            this.colSP.MinimumWidth = 8;
            this.colSP.Name = "colSP";
            this.colSP.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Location = new System.Drawing.Point(1047, 446);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // qlyphongtroDataSet
            // 
            this.qlyphongtroDataSet.DataSetName = "QlyphongtroDataSet";
            this.qlyphongtroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qlyphongtroDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // fKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1243, 485);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbTTKH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fKhachhang";
            this.Text = "fKhachhang";
            this.Load += new System.EventHandler(this.fKhachhang_Load);
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyphongtroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.CheckBox chbNam;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.CheckBox chbKhac;
        private System.Windows.Forms.CheckBox chbNu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP;
        private thulan2.QlyphongtroDataSet qlyphongtroDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private thulan2.QlyphongtroDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
    }
}