namespace BaiTapWinForm.TH05c.BaiMau3_TreeView
{
    partial class frmTreeView
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
            this.trv_DS = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            this.btn_ThemPB = new System.Windows.Forms.Button();
            this.btn_XoaPB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_phongban = new System.Windows.Forms.ComboBox();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban";
            // 
            // trv_DS
            // 
            this.trv_DS.Location = new System.Drawing.Point(12, 32);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new System.Drawing.Size(250, 250);
            this.trv_DS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng ban";
            // 
            // txt_phongban
            // 
            this.txt_phongban.Location = new System.Drawing.Point(100, 294);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.Size = new System.Drawing.Size(162, 25);
            this.txt_phongban.TabIndex = 3;
            // 
            // btn_ThemPB
            // 
            this.btn_ThemPB.Location = new System.Drawing.Point(100, 328);
            this.btn_ThemPB.Name = "btn_ThemPB";
            this.btn_ThemPB.Size = new System.Drawing.Size(162, 30);
            this.btn_ThemPB.TabIndex = 4;
            this.btn_ThemPB.Text = "Thêm phòng ban";
            this.btn_ThemPB.UseVisualStyleBackColor = true;
            this.btn_ThemPB.Click += new System.EventHandler(this.btn_ThemPB_Click);
            // 
            // btn_XoaPB
            // 
            this.btn_XoaPB.Location = new System.Drawing.Point(100, 364);
            this.btn_XoaPB.Name = "btn_XoaPB";
            this.btn_XoaPB.Size = new System.Drawing.Size(162, 30);
            this.btn_XoaPB.TabIndex = 5;
            this.btn_XoaPB.Text = "Xóa phòng ban";
            this.btn_XoaPB.UseVisualStyleBackColor = true;
            this.btn_XoaPB.Click += new System.EventHandler(this.btn_XoaPB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(285, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã số";
            // 
            // txt_maso
            // 
            this.txt_maso.Location = new System.Drawing.Point(370, 53);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(100, 25);
            this.txt_maso.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(550, 53);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(195, 25);
            this.txt_hoten.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(370, 97);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(375, 25);
            this.txt_diachi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phòng ban";
            // 
            // cbo_phongban
            // 
            this.cbo_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phongban.FormattingEnabled = true;
            this.cbo_phongban.Location = new System.Drawing.Point(370, 141);
            this.cbo_phongban.Name = "cbo_phongban";
            this.cbo_phongban.Size = new System.Drawing.Size(375, 25);
            this.cbo_phongban.TabIndex = 14;
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(370, 185);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(80, 30);
            this.btn_ThemNV.TabIndex = 15;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(460, 185);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(80, 30);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trv_DS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phongban);
            this.Controls.Add(this.btn_ThemPB);
            this.Controls.Add(this.btn_XoaPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_phongban);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.btn_Thoat);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng ban – Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTreeView_FormClosing);
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trv_DS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phongban;
        private System.Windows.Forms.Button btn_ThemPB;
        private System.Windows.Forms.Button btn_XoaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_phongban;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_Thoat;
    }
}
