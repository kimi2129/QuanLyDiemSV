namespace QuanLyDiem
{
    partial class FrmDiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo8 = new System.Windows.Forms.RadioButton();
            this.rdo7 = new System.Windows.Forms.RadioButton();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo6 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.cmbMaMon = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewDiem = new System.Windows.Forms.DataGridView();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Điểm sinh viên";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(235, 104);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(231, 26);
            this.txtMaLop.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lần thi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo8);
            this.groupBox1.Controls.Add(this.rdo7);
            this.groupBox1.Controls.Add(this.rdo4);
            this.groupBox1.Controls.Add(this.rdo6);
            this.groupBox1.Controls.Add(this.rdo3);
            this.groupBox1.Controls.Add(this.rdo5);
            this.groupBox1.Controls.Add(this.rdo2);
            this.groupBox1.Controls.Add(this.rdo1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(548, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 110);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học kỳ";
            // 
            // rdo8
            // 
            this.rdo8.AutoSize = true;
            this.rdo8.Location = new System.Drawing.Point(300, 56);
            this.rdo8.Name = "rdo8";
            this.rdo8.Size = new System.Drawing.Size(50, 34);
            this.rdo8.TabIndex = 16;
            this.rdo8.TabStop = true;
            this.rdo8.Text = "8";
            this.rdo8.UseVisualStyleBackColor = true;
            // 
            // rdo7
            // 
            this.rdo7.AutoSize = true;
            this.rdo7.Location = new System.Drawing.Point(300, 26);
            this.rdo7.Name = "rdo7";
            this.rdo7.Size = new System.Drawing.Size(50, 34);
            this.rdo7.TabIndex = 17;
            this.rdo7.TabStop = true;
            this.rdo7.Text = "7";
            this.rdo7.UseVisualStyleBackColor = true;
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(167, 56);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(50, 34);
            this.rdo4.TabIndex = 18;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "4";
            this.rdo4.UseVisualStyleBackColor = true;
            // 
            // rdo6
            // 
            this.rdo6.AutoSize = true;
            this.rdo6.Location = new System.Drawing.Point(234, 56);
            this.rdo6.Name = "rdo6";
            this.rdo6.Size = new System.Drawing.Size(50, 34);
            this.rdo6.TabIndex = 19;
            this.rdo6.TabStop = true;
            this.rdo6.Text = "6";
            this.rdo6.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(167, 26);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(50, 34);
            this.rdo3.TabIndex = 20;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "3";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(234, 26);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(50, 34);
            this.rdo5.TabIndex = 21;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(99, 56);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(50, 34);
            this.rdo2.TabIndex = 22;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "2";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(99, 26);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(50, 34);
            this.rdo1.TabIndex = 23;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "1";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Location = new System.Drawing.Point(641, 264);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(128, 26);
            this.txtLanThi.TabIndex = 17;
            // 
            // cmbMaMon
            // 
            this.cmbMaMon.FormattingEnabled = true;
            this.cmbMaMon.Location = new System.Drawing.Point(231, 260);
            this.cmbMaMon.Name = "cmbMaMon";
            this.cmbMaMon.Size = new System.Drawing.Size(231, 28);
            this.cmbMaMon.TabIndex = 19;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(843, 664);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 63);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(694, 664);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 63);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(548, 664);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 63);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(395, 664);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 63);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(248, 664);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 63);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(98, 664);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 63);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewDiem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 293);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách SV đủ điều kiện nhập điểm";
            // 
            // GridViewDiem
            // 
            this.GridViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaSV,
            this.clmMaLop,
            this.clmMaMon,
            this.clmHocKy,
            this.clmLanThi,
            this.clmDiem});
            this.GridViewDiem.Location = new System.Drawing.Point(31, 50);
            this.GridViewDiem.Name = "GridViewDiem";
            this.GridViewDiem.RowHeadersWidth = 62;
            this.GridViewDiem.RowTemplate.Height = 28;
            this.GridViewDiem.Size = new System.Drawing.Size(893, 215);
            this.GridViewDiem.TabIndex = 19;
            // 
            // clmMaSV
            // 
            this.clmMaSV.DataPropertyName = "MaSV";
            this.clmMaSV.HeaderText = "Mã sinh viên";
            this.clmMaSV.MinimumWidth = 8;
            this.clmMaSV.Name = "clmMaSV";
            this.clmMaSV.Width = 150;
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            this.clmMaLop.HeaderText = "Mã lớp";
            this.clmMaLop.MinimumWidth = 8;
            this.clmMaLop.Name = "clmMaLop";
            this.clmMaLop.Width = 150;
            // 
            // clmMaMon
            // 
            this.clmMaMon.DataPropertyName = "MaMon";
            this.clmMaMon.HeaderText = "Mã môn";
            this.clmMaMon.MinimumWidth = 8;
            this.clmMaMon.Name = "clmMaMon";
            this.clmMaMon.Width = 150;
            // 
            // clmHocKy
            // 
            this.clmHocKy.DataPropertyName = "HocKy";
            this.clmHocKy.HeaderText = "Học kỳ";
            this.clmHocKy.MinimumWidth = 8;
            this.clmHocKy.Name = "clmHocKy";
            this.clmHocKy.Width = 150;
            // 
            // clmLanThi
            // 
            this.clmLanThi.DataPropertyName = "LanThi";
            this.clmLanThi.HeaderText = "Lần Thi";
            this.clmLanThi.MinimumWidth = 8;
            this.clmLanThi.Name = "clmLanThi";
            this.clmLanThi.Width = 150;
            // 
            // clmDiem
            // 
            this.clmDiem.DataPropertyName = "Diem";
            this.clmDiem.HeaderText = "Điểm";
            this.clmDiem.MinimumWidth = 8;
            this.clmDiem.Name = "clmDiem";
            this.clmDiem.Width = 150;
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 760);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbMaMon);
            this.Controls.Add(this.txtLanThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDiem";
            this.Text = "FrmDiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo8;
        private System.Windows.Forms.RadioButton rdo7;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo6;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.ComboBox cmbMaMon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiem;
    }
}
