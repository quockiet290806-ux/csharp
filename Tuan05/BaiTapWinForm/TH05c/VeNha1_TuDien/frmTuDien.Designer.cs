namespace BaiTapWinForm.TH05c.VeNha1_TuDien
{
    partial class frmTuDien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnhViet = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNghiaViet = new System.Windows.Forms.TextBox();
            this.tabVietAnh = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboViet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNghiaAnh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnhViet);
            this.tabControl1.Controls.Add(this.tabVietAnh);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 310);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnhViet
            // 
            this.tabAnhViet.Controls.Add(this.label1);
            this.tabAnhViet.Controls.Add(this.cboAnh);
            this.tabAnhViet.Controls.Add(this.label2);
            this.tabAnhViet.Controls.Add(this.txtNghiaViet);
            this.tabAnhViet.Location = new System.Drawing.Point(4, 22);
            this.tabAnhViet.Name = "tabAnhViet";
            this.tabAnhViet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnhViet.Size = new System.Drawing.Size(398, 284);
            this.tabAnhViet.TabIndex = 0;
            this.tabAnhViet.Text = "ANH - VIỆT";
            this.tabAnhViet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiếng Anh";
            // 
            // cboAnh
            // 
            this.cboAnh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboAnh.FormattingEnabled = true;
            this.cboAnh.Location = new System.Drawing.Point(12, 30);
            this.cboAnh.Name = "cboAnh";
            this.cboAnh.Size = new System.Drawing.Size(170, 240);
            this.cboAnh.TabIndex = 1;
            this.cboAnh.TextUpdate += new System.EventHandler(this.cboAnh_TextUpdate);
            this.cboAnh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAnh_KeyDown);
            this.cboAnh.Click += new System.EventHandler(this.cboAnh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiếng Việt";
            // 
            // txtNghiaViet
            // 
            this.txtNghiaViet.Location = new System.Drawing.Point(200, 30);
            this.txtNghiaViet.Multiline = true;
            this.txtNghiaViet.Name = "txtNghiaViet";
            this.txtNghiaViet.ReadOnly = true;
            this.txtNghiaViet.Size = new System.Drawing.Size(185, 240);
            this.txtNghiaViet.TabIndex = 3;
            // 
            // tabVietAnh
            // 
            this.tabVietAnh.Controls.Add(this.label3);
            this.tabVietAnh.Controls.Add(this.cboViet);
            this.tabVietAnh.Controls.Add(this.label4);
            this.tabVietAnh.Controls.Add(this.txtNghiaAnh);
            this.tabVietAnh.Location = new System.Drawing.Point(4, 22);
            this.tabVietAnh.Name = "tabVietAnh";
            this.tabVietAnh.Padding = new System.Windows.Forms.Padding(3);
            this.tabVietAnh.Size = new System.Drawing.Size(398, 284);
            this.tabVietAnh.TabIndex = 1;
            this.tabVietAnh.Text = "VIỆT - ANH";
            this.tabVietAnh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiếng Việt";
            // 
            // cboViet
            // 
            this.cboViet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboViet.FormattingEnabled = true;
            this.cboViet.Location = new System.Drawing.Point(12, 30);
            this.cboViet.Name = "cboViet";
            this.cboViet.Size = new System.Drawing.Size(170, 240);
            this.cboViet.TabIndex = 1;
            this.cboViet.TextUpdate += new System.EventHandler(this.cboViet_TextUpdate);
            this.cboViet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboViet_KeyDown);
            this.cboViet.Click += new System.EventHandler(this.cboViet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiếng Anh";
            // 
            // txtNghiaAnh
            // 
            this.txtNghiaAnh.Location = new System.Drawing.Point(200, 30);
            this.txtNghiaAnh.Multiline = true;
            this.txtNghiaAnh.Name = "txtNghiaAnh";
            this.txtNghiaAnh.ReadOnly = true;
            this.txtNghiaAnh.Size = new System.Drawing.Size(185, 240);
            this.txtNghiaAnh.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(333, 332);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 26);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTuDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmTuDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.Load += new System.EventHandler(this.frmTuDien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAnhViet.ResumeLayout(false);
            this.tabAnhViet.PerformLayout();
            this.tabVietAnh.ResumeLayout(false);
            this.tabVietAnh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnhViet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNghiaViet;
        private System.Windows.Forms.TabPage tabVietAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboViet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNghiaAnh;
        private System.Windows.Forms.Button btnThoat;
    }
}
