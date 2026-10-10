namespace BaiTapWinForm.TH05c.BaiMau1_ListBox
{
    partial class frmListBox
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
            this.lst_Trai = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnQuaPhaiAll = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaTraiAll = new System.Windows.Forms.Button();
            this.lst_Phai = new System.Windows.Forms.ListBox();
            this.btnChuyenTuyY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Trai
            // 
            this.lst_Trai.FormattingEnabled = true;
            this.lst_Trai.ItemHeight = 18;
            this.lst_Trai.Items.AddRange(new object[] {
            "Cốc",
            "Ổi",
            "Xoài",
            "Me",
            "Bưởi",
            "Cam"});
            this.lst_Trai.Location = new System.Drawing.Point(12, 12);
            this.lst_Trai.Name = "lst_Trai";
            this.lst_Trai.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Trai.Size = new System.Drawing.Size(180, 256);
            this.lst_Trai.TabIndex = 0;
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Location = new System.Drawing.Point(216, 40);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(88, 34);
            this.btnQuaPhai.TabIndex = 1;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnQuaPhaiAll
            // 
            this.btnQuaPhaiAll.Location = new System.Drawing.Point(216, 90);
            this.btnQuaPhaiAll.Name = "btnQuaPhaiAll";
            this.btnQuaPhaiAll.Size = new System.Drawing.Size(88, 34);
            this.btnQuaPhaiAll.TabIndex = 2;
            this.btnQuaPhaiAll.Text = ">>";
            this.btnQuaPhaiAll.UseVisualStyleBackColor = true;
            this.btnQuaPhaiAll.Click += new System.EventHandler(this.btnQuaPhaiAll_Click);
            // 
            // btnQuaTrai
            // 
            this.btnQuaTrai.Location = new System.Drawing.Point(216, 140);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(88, 34);
            this.btnQuaTrai.TabIndex = 3;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnQuaTraiAll
            // 
            this.btnQuaTraiAll.Location = new System.Drawing.Point(216, 190);
            this.btnQuaTraiAll.Name = "btnQuaTraiAll";
            this.btnQuaTraiAll.Size = new System.Drawing.Size(88, 34);
            this.btnQuaTraiAll.TabIndex = 4;
            this.btnQuaTraiAll.Text = "<<";
            this.btnQuaTraiAll.UseVisualStyleBackColor = true;
            this.btnQuaTraiAll.Click += new System.EventHandler(this.btnQuaTraiAll_Click);
            // 
            // lst_Phai
            // 
            this.lst_Phai.FormattingEnabled = true;
            this.lst_Phai.ItemHeight = 18;
            this.lst_Phai.Location = new System.Drawing.Point(328, 12);
            this.lst_Phai.Name = "lst_Phai";
            this.lst_Phai.Size = new System.Drawing.Size(180, 256);
            this.lst_Phai.TabIndex = 5;
            // 
            // btnChuyenTuyY
            // 
            this.btnChuyenTuyY.Location = new System.Drawing.Point(12, 282);
            this.btnChuyenTuyY.Name = "btnChuyenTuyY";
            this.btnChuyenTuyY.Size = new System.Drawing.Size(180, 34);
            this.btnChuyenTuyY.TabIndex = 6;
            this.btnChuyenTuyY.Text = "Chuyển tùy ý";
            this.btnChuyenTuyY.UseVisualStyleBackColor = true;
            this.btnChuyenTuyY.Click += new System.EventHandler(this.btnChuyenTuyY_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 330);
            this.Controls.Add(this.lst_Trai);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.btnQuaPhaiAll);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnQuaTraiAll);
            this.Controls.Add(this.lst_Phai);
            this.Controls.Add(this.btnChuyenTuyY);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng Listbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Trai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnQuaPhaiAll;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaTraiAll;
        private System.Windows.Forms.ListBox lst_Phai;
        private System.Windows.Forms.Button btnChuyenTuyY;
    }
}
