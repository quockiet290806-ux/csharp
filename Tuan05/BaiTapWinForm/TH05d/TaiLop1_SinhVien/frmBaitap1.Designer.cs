namespace BaiTapWinForm.TH05d.TaiLop1_SinhVien
{
    partial class frmBaitap1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkHoa = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgoaiNgu = new System.Windows.Forms.ColumnHeader();
            this.colDanToc = new System.Windows.Forms.ColumnHeader();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(190, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(240, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(190, 54);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(240, 20);
            this.txtMaSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(190, 90);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 5;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(290, 90);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 6;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngoại ngữ";
            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Location = new System.Drawing.Point(190, 125);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(45, 17);
            this.chkAnh.TabIndex = 8;
            this.chkAnh.Text = "Anh";
            this.chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            this.chkPhap.AutoSize = true;
            this.chkPhap.Location = new System.Drawing.Point(280, 125);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new System.Drawing.Size(51, 17);
            this.chkPhap.TabIndex = 9;
            this.chkPhap.Text = "Pháp";
            this.chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkHoa
            // 
            this.chkHoa.AutoSize = true;
            this.chkHoa.Location = new System.Drawing.Point(370, 125);
            this.chkHoa.Name = "chkHoa";
            this.chkHoa.Size = new System.Drawing.Size(45, 17);
            this.chkHoa.TabIndex = 10;
            this.chkHoa.Text = "Hoa";
            this.chkHoa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dân tộc";
            // 
            // cboDanToc
            // 
            this.cboDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.Location = new System.Drawing.Point(190, 158);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(240, 21);
            this.cboDanToc.TabIndex = 12;
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colMaSV,
            this.colGioiTinh,
            this.colNgoaiNgu,
            this.colDanToc});
            this.lvSinhVien.ContextMenuStrip = this.cmsListView;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(12, 195);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(496, 200);
            this.lvSinhVien.TabIndex = 13;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 140;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã sinh viên";
            this.colMaSV.Width = 90;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            // 
            // colNgoaiNgu
            // 
            this.colNgoaiNgu.Text = "Ngoại ngữ";
            this.colNgoaiNgu.Width = 110;
            // 
            // colDanToc
            // 
            this.colDanToc.Text = "Dân tộc";
            this.colDanToc.Width = 80;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(110, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 34);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 34);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(320, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 34);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmsListView
            // 
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(95, 26);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(94, 22);
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            // 
            // frmBaitap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDanToc);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "frmBaitap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaitap1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaitap1_FormClosing);
            this.Load += new System.EventHandler(this.frmBaitap1_Load);
            this.cmsListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkHoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgoaiNgu;
        private System.Windows.Forms.ColumnHeader colDanToc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
    }
}
