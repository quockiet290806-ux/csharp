namespace BaiTapWinForm.TH05d.NangCao1_HocVien
{
    partial class frmNhapHocVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B"});
            this.cboLop.Location = new System.Drawing.Point(100, 57);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 21);
            this.cboLop.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(100, 100);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 28);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(205, 100);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(95, 28);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmNhapHocVien
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTroVe);
            this.Name = "frmNhapHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập học viên mới";
            this.Load += new System.EventHandler(this.frmNhapHocVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTroVe;
    }
}
