namespace BaiTapWinForm.TH05d.BaiMau2_ListView
{
    partial class frmListView
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lstv1 = new System.Windows.Forms.ListView();
            this.MSSV = new System.Windows.Forms.ColumnHeader();
            this.HOTEN = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(20, 12);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 26);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(110, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 26);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(200, 12);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 26);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(100, 52);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(300, 20);
            this.txtmssv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(100, 85);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(300, 20);
            this.txthoten.TabIndex = 6;
            // 
            // lstv1
            // 
            this.lstv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.HOTEN});
            this.lstv1.FullRowSelect = true;
            this.lstv1.GridLines = true;
            this.lstv1.HideSelection = false;
            this.lstv1.Location = new System.Drawing.Point(20, 120);
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new System.Drawing.Size(380, 195);
            this.lstv1.TabIndex = 7;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = System.Windows.Forms.View.Details;
            this.lstv1.SelectedIndexChanged += new System.EventHandler(this.lstv1_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "MÃ SỐ SV";
            this.MSSV.Width = 120;
            // 
            // HOTEN
            // 
            this.HOTEN.Text = "HỌ VÀ TÊN";
            this.HOTEN.Width = 230;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 330);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.lstv1);
            this.Name = "frmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.ListView lstv1;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HOTEN;
    }
}
