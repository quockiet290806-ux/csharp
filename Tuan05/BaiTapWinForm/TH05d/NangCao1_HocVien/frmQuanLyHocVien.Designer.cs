namespace BaiTapWinForm.TH05d.NangCao1_HocVien
{
    partial class frmQuanLyHocVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapNhat,
            this.mnuKetThuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapMoi,
            this.mnuChuyenB,
            this.mnuChuyenA,
            this.mnuXoa});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(70, 20);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuNhapMoi
            // 
            this.mnuNhapMoi.Name = "mnuNhapMoi";
            this.mnuNhapMoi.Size = new System.Drawing.Size(159, 22);
            this.mnuNhapMoi.Text = "Nhập học viên mới";
            this.mnuNhapMoi.Click += new System.EventHandler(this.mnuNhapMoi_Click);
            // 
            // mnuChuyenB
            // 
            this.mnuChuyenB.Name = "mnuChuyenB";
            this.mnuChuyenB.Size = new System.Drawing.Size(159, 22);
            this.mnuChuyenB.Text = "Chuyển sang lớp B";
            this.mnuChuyenB.Click += new System.EventHandler(this.mnuChuyenB_Click);
            // 
            // mnuChuyenA
            // 
            this.mnuChuyenA.Name = "mnuChuyenA";
            this.mnuChuyenA.Size = new System.Drawing.Size(159, 22);
            this.mnuChuyenA.Text = "Chuyển sang lớp A";
            this.mnuChuyenA.Click += new System.EventHandler(this.mnuChuyenA_Click);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(124, 22);
            this.mnuXoa.Text = "Xóa học viên";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(65, 20);
            this.mnuKetThuc.Text = "&Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLopA);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 13;
            this.lstLopA.Items.AddRange(new object[] {
            "Trần Hùng",
            "Nguyễn Hưng",
            "Lâm Tứ"});
            this.lstLopA.Location = new System.Drawing.Point(12, 22);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(166, 186);
            this.lstLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopB);
            this.groupBox2.Location = new System.Drawing.Point(230, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 13;
            this.lstLopB.Items.AddRange(new object[] {
            "Tuấn Hưng",
            "Hồng Ngọc",
            "Anh Minh",
            "Bảo Lâm"});
            this.lstLopB.Location = new System.Drawing.Point(12, 22);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(166, 186);
            this.lstLopB.TabIndex = 0;
            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 280);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLyHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLopB;
    }
}
