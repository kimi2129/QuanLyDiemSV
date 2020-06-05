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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiem));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewDiem = new System.Windows.Forms.DataGridView();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbMaMon = new System.Windows.Forms.ComboBox();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdo8 = new System.Windows.Forms.RadioButton();
            this.rdo7 = new System.Windows.Forms.RadioButton();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo6 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Điểm sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewDiem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(611, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 292);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
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
            this.GridViewDiem.Location = new System.Drawing.Point(32, 49);
            this.GridViewDiem.Name = "GridViewDiem";
            this.GridViewDiem.RowHeadersWidth = 62;
            this.GridViewDiem.RowTemplate.Height = 28;
            this.GridViewDiem.Size = new System.Drawing.Size(640, 215);
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
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1226, 403);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 63);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(1100, 403);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 63);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(978, 403);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 63);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(853, 403);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 63);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(730, 403);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 63);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(607, 403);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 63);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(53, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 535);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbMaMon);
            this.groupBox1.Controls.Add(this.txtLanThi);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 398);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 59);
            this.button1.TabIndex = 71;
            this.button1.Text = "Danh sách sinh viên";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 28);
            this.comboBox1.TabIndex = 70;
            // 
            // cmbMaMon
            // 
            this.cmbMaMon.FormattingEnabled = true;
            this.cmbMaMon.Location = new System.Drawing.Point(128, 225);
            this.cmbMaMon.Name = "cmbMaMon";
            this.cmbMaMon.Size = new System.Drawing.Size(235, 28);
            this.cmbMaMon.TabIndex = 69;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Location = new System.Drawing.Point(118, 276);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(128, 26);
            this.txtLanThi.TabIndex = 68;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdo8);
            this.groupBox4.Controls.Add(this.rdo7);
            this.groupBox4.Controls.Add(this.rdo4);
            this.groupBox4.Controls.Add(this.rdo6);
            this.groupBox4.Controls.Add(this.rdo3);
            this.groupBox4.Controls.Add(this.rdo5);
            this.groupBox4.Controls.Add(this.rdo2);
            this.groupBox4.Controls.Add(this.rdo1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 117);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Học kỳ";
            // 
            // rdo8
            // 
            this.rdo8.AutoSize = true;
            this.rdo8.Location = new System.Drawing.Point(279, 65);
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
            this.rdo7.Location = new System.Drawing.Point(223, 65);
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
            this.rdo4.Location = new System.Drawing.Point(279, 25);
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
            this.rdo6.Location = new System.Drawing.Point(167, 65);
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
            this.rdo3.Location = new System.Drawing.Point(223, 25);
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
            this.rdo5.Location = new System.Drawing.Point(109, 65);
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
            this.rdo2.Location = new System.Drawing.Point(167, 25);
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
            this.rdo1.Location = new System.Drawing.Point(109, 25);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(50, 34);
            this.rdo1.TabIndex = 23;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "1";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 30);
            this.label4.TabIndex = 65;
            this.label4.Text = "Lần thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã lớp";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(360, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 58);
            this.btnTimKiem.TabIndex = 65;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã sinh viên";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(907, 529);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(128, 26);
            this.txtDiem.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(810, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 69;
            this.label6.Text = "Điểm SV";
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 618);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Name = "FrmDiem";
            this.Text = "FrmDiem";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbMaMon;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdo8;
        private System.Windows.Forms.RadioButton rdo7;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo6;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label6;
    }
}
