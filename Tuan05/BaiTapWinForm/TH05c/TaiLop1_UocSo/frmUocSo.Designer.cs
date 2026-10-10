namespace BaiTapWinForm.TH05c.TaiLop1_UocSo
{
    partial class frmUocSo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnSoLuongChan = new System.Windows.Forms.Button();
            this.btnSoLuongNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(15, 25);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(90, 20);
            this.txtSo.TabIndex = 0;
            this.txtSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(112, 23);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cboSo
            // 
            this.cboSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(15, 65);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(172, 21);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstUocSo);
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 13;
            this.lstUocSo.Location = new System.Drawing.Point(12, 20);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(214, 82);
            this.lstUocSo.TabIndex = 0;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(230, 132);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(238, 26);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "&Tổng các ước số";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnSoLuongChan
            // 
            this.btnSoLuongChan.Location = new System.Drawing.Point(230, 164);
            this.btnSoLuongChan.Name = "btnSoLuongChan";
            this.btnSoLuongChan.Size = new System.Drawing.Size(238, 26);
            this.btnSoLuongChan.TabIndex = 3;
            this.btnSoLuongChan.Text = "&Số lượng các ước số chẵn";
            this.btnSoLuongChan.UseVisualStyleBackColor = true;
            this.btnSoLuongChan.Click += new System.EventHandler(this.btnSoLuongChan_Click);
            // 
            // btnSoLuongNguyenTo
            // 
            this.btnSoLuongNguyenTo.Location = new System.Drawing.Point(230, 196);
            this.btnSoLuongNguyenTo.Name = "btnSoLuongNguyenTo";
            this.btnSoLuongNguyenTo.Size = new System.Drawing.Size(238, 26);
            this.btnSoLuongNguyenTo.TabIndex = 4;
            this.btnSoLuongNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoLuongNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongNguyenTo.Click += new System.EventHandler(this.btnSoLuongNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(137, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 26);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmUocSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnSoLuongChan);
            this.Controls.Add(this.btnSoLuongNguyenTo);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmUocSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUocSo_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnSoLuongChan;
        private System.Windows.Forms.Button btnSoLuongNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}
