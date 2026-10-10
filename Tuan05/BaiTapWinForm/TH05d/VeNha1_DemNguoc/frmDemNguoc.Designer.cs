namespace BaiTapWinForm.TH05d.VeNha1_DemNguoc
{
    partial class frmDemNguoc
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
            this.txtGio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiay = new System.Windows.Forms.TextBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giờ";
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(70, 19);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(50, 20);
            this.txtGio.TabIndex = 1;
            this.txtGio.Text = "0";
            this.txtGio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThoiGian_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phút";
            // 
            // txtPhut
            // 
            this.txtPhut.Location = new System.Drawing.Point(180, 19);
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(50, 20);
            this.txtPhut.TabIndex = 3;
            this.txtPhut.Text = "0";
            this.txtPhut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThoiGian_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giây";
            // 
            // txtGiay
            // 
            this.txtGiay.Location = new System.Drawing.Point(290, 19);
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(50, 20);
            this.txtGiay.TabIndex = 5;
            this.txtGiay.Text = "0";
            this.txtGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThoiGian_KeyPress);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGian.Location = new System.Drawing.Point(12, 55);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(376, 95);
            this.lblThoiGian.TabIndex = 6;
            this.lblThoiGian.Text = "00:00:00";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(45, 170);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(95, 32);
            this.btnBatDau.TabIndex = 7;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.Enabled = false;
            this.btnTamDung.Location = new System.Drawing.Point(152, 170);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(95, 32);
            this.btnTamDung.TabIndex = 8;
            this.btnTamDung.Text = "Tạm dừng";
            this.btnTamDung.UseVisualStyleBackColor = true;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(259, 170);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(95, 32);
            this.btnDatLai.TabIndex = 9;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDemNguoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.btnDatLai);
            this.Name = "frmDemNguoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đếm ngược thời gian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiay;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Timer timer1;
    }
}
