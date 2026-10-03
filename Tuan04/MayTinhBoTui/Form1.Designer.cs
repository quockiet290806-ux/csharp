namespace MayTinhBoTui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtManHinh;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtManHinh = new System.Windows.Forms.TextBox();

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Times New Roman",
                24F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(37, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(250, 36);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Máy Tính Bỏ Túi";

            // 
            // txtManHinh
            // 
            this.txtManHinh.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F
            );
            this.txtManHinh.Location = new System.Drawing.Point(30, 75);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.ReadOnly = true;
            this.txtManHinh.Size = new System.Drawing.Size(260, 29);
            this.txtManHinh.TabIndex = 1;
            this.txtManHinh.Text = "0";
            this.txtManHinh.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // =========================
            // HÀNG 1: 1 2 3 4
            // =========================

            this.btn1.Location = new System.Drawing.Point(30, 120);
            this.btn1.Size = new System.Drawing.Size(53, 38);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);

            this.btn2.Location = new System.Drawing.Point(96, 120);
            this.btn2.Size = new System.Drawing.Size(53, 38);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);

            this.btn3.Location = new System.Drawing.Point(162, 120);
            this.btn3.Size = new System.Drawing.Size(53, 38);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);

            this.btn4.Location = new System.Drawing.Point(228, 120);
            this.btn4.Size = new System.Drawing.Size(53, 38);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);

            // =========================
            // HÀNG 2: 5 6 7 8
            // =========================

            this.btn5.Location = new System.Drawing.Point(30, 168);
            this.btn5.Size = new System.Drawing.Size(53, 38);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);

            this.btn6.Location = new System.Drawing.Point(96, 168);
            this.btn6.Size = new System.Drawing.Size(53, 38);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);

            this.btn7.Location = new System.Drawing.Point(162, 168);
            this.btn7.Size = new System.Drawing.Size(53, 38);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);

            this.btn8.Location = new System.Drawing.Point(228, 168);
            this.btn8.Size = new System.Drawing.Size(53, 38);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);

            // =========================
            // HÀNG 3: 9 0 = C
            // =========================

            this.btn9.Location = new System.Drawing.Point(30, 216);
            this.btn9.Size = new System.Drawing.Size(53, 38);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);

            this.btn0.Location = new System.Drawing.Point(96, 216);
            this.btn0.Size = new System.Drawing.Size(53, 38);
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);

            this.btnBang.Location = new System.Drawing.Point(162, 216);
            this.btnBang.Size = new System.Drawing.Size(53, 38);
            this.btnBang.Text = "=";
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);

            this.btnXoa.Location = new System.Drawing.Point(228, 216);
            this.btnXoa.Size = new System.Drawing.Size(53, 38);
            this.btnXoa.Text = "C";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // =========================
            // HÀNG 4: + - * /
            // =========================

            this.btnCong.Location = new System.Drawing.Point(30, 264);
            this.btnCong.Size = new System.Drawing.Size(53, 38);
            this.btnCong.Text = "+";
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);

            this.btnTru.Location = new System.Drawing.Point(96, 264);
            this.btnTru.Size = new System.Drawing.Size(53, 38);
            this.btnTru.Text = "-";
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);

            this.btnNhan.Location = new System.Drawing.Point(162, 264);
            this.btnNhan.Size = new System.Drawing.Size(53, 38);
            this.btnNhan.Text = "*";
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);

            this.btnChia.Location = new System.Drawing.Point(228, 264);
            this.btnChia.Size = new System.Drawing.Size(53, 38);
            this.btnChia.Text = "/";
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(320, 330);

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.txtManHinh);

            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);

            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);

            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnXoa);

            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Tính Bỏ Túi";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}