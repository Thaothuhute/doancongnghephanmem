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
            this.lblSophong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhongtro = new System.Windows.Forms.DataGridView();
            this.colSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSotang = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbST = new System.Windows.Forms.ComboBox();
            this.cbbSP = new System.Windows.Forms.ComboBox();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblQLPT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongtro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSophong.ForeColor = System.Drawing.Color.Indigo;
            this.lblSophong.Location = new System.Drawing.Point(44, 18);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(77, 17);
            this.lblSophong.TabIndex = 1;
            this.lblSophong.Text = "Số phòng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnThem.Location = new System.Drawing.Point(24, 9);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 27);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPhongtro
            // 
            this.dgvPhongtro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPhongtro.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvPhongtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongtro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSP,
            this.colST,
            this.colGia,
            this.colTrangthai});
            this.dgvPhongtro.Location = new System.Drawing.Point(371, 77);
            this.dgvPhongtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhongtro.Name = "dgvPhongtro";
            this.dgvPhongtro.RowHeadersWidth = 62;
            this.dgvPhongtro.RowTemplate.Height = 28;
            this.dgvPhongtro.Size = new System.Drawing.Size(813, 290);
            this.dgvPhongtro.TabIndex = 3;
            // 
            // colSP
            // 
            this.colSP.HeaderText = "Số phòng";
            this.colSP.MinimumWidth = 8;
            this.colSP.Name = "colSP";
            this.colSP.Width = 150;
            // 
            // colST
            // 
            this.colST.HeaderText = "Số tầng";
            this.colST.MinimumWidth = 8;
            this.colST.Name = "colST";
            this.colST.Width = 150;
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
            // lblSotang
            // 
            this.lblSotang.AutoSize = true;
            this.lblSotang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSotang.ForeColor = System.Drawing.Color.Indigo;
            this.lblSotang.Location = new System.Drawing.Point(54, 46);
            this.lblSotang.Name = "lblSotang";
            this.lblSotang.Size = new System.Drawing.Size(64, 17);
            this.lblSotang.TabIndex = 1;
            this.lblSotang.Text = "Số tầng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Indigo;
            this.lblGia.Location = new System.Drawing.Point(85, 82);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(33, 17);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.ForeColor = System.Drawing.Color.Indigo;
            this.lblTrangthai.Location = new System.Drawing.Point(41, 112);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(83, 17);
            this.lblTrangthai.TabIndex = 1;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(140, 79);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(89, 22);
            this.txtGia.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSua.Location = new System.Drawing.Point(241, 9);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Location = new System.Drawing.Point(132, 9);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 27);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLuu.Location = new System.Drawing.Point(25, 39);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 27);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHuy.Location = new System.Drawing.Point(132, 39);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 27);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.cbbST);
            this.panel1.Controls.Add(this.cbbSP);
            this.panel1.Controls.Add(this.cbbTT);
            this.panel1.Controls.Add(this.lblSophong);
            this.panel1.Controls.Add(this.lblSotang);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.lblTrangthai);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Location = new System.Drawing.Point(20, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 146);
            this.panel1.TabIndex = 4;
            // 
            // cbbST
            // 
            this.cbbST.FormattingEnabled = true;
            this.cbbST.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbST.Location = new System.Drawing.Point(140, 46);
            this.cbbST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbST.Name = "cbbST";
            this.cbbST.Size = new System.Drawing.Size(108, 24);
            this.cbbST.TabIndex = 2;
            // 
            // cbbSP
            // 
            this.cbbSP.FormattingEnabled = true;
            this.cbbSP.Location = new System.Drawing.Point(140, 18);
            this.cbbSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSP.Name = "cbbSP";
            this.cbbSP.Size = new System.Drawing.Size(108, 24);
            this.cbbSP.TabIndex = 2;
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Location = new System.Drawing.Point(140, 112);
            this.cbbTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(108, 24);
            this.cbbTT.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 228);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 81);
            this.panel2.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTim.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTim.Location = new System.Drawing.Point(241, 39);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(67, 27);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Window;
            this.btnThoat.Location = new System.Drawing.Point(1098, 392);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 28);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblQLPT
            // 
            this.lblQLPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQLPT.AutoSize = true;
            this.lblQLPT.BackColor = System.Drawing.Color.OldLace;
            this.lblQLPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPT.ForeColor = System.Drawing.Color.Indigo;
            this.lblQLPT.Location = new System.Drawing.Point(475, 16);
            this.lblQLPT.Name = "lblQLPT";
            this.lblQLPT.Size = new System.Drawing.Size(276, 29);
            this.lblQLPT.TabIndex = 7;
            this.lblQLPT.Text = "QUẢN LÍ PHÒNG TRỌ";
            // 
            // fPhongtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1237, 478);
            this.Controls.Add(this.lblQLPT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhongtro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPhongtro";
            this.Text = "fPhongtro";
            this.Load += new System.EventHandler(this.fPhongtro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongtro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhongtro;
        private System.Windows.Forms.Label lblSotang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbTT;
        private System.Windows.Forms.ComboBox cbbST;
        private System.Windows.Forms.ComboBox cbbSP;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblQLPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colST;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangthai;
    }
}