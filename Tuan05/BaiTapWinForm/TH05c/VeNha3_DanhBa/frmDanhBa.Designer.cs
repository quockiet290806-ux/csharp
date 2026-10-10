namespace BaiTapWinForm.TH05c.VeNha3_DanhBa
{
    partial class frmDanhBa
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
            this.trvDanhBa = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgDanhBa = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDanhBa
            // 
            this.trvDanhBa.ImageIndex = 0;
            this.trvDanhBa.ImageList = this.imgDanhBa;
            this.trvDanhBa.Location = new System.Drawing.Point(12, 12);
            this.trvDanhBa.Name = "trvDanhBa";
            this.trvDanhBa.SelectedImageIndex = 0;
            this.trvDanhBa.Size = new System.Drawing.Size(220, 376);
            this.trvDanhBa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(250, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(473, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgDanhBa
            // 
            this.imgDanhBa.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgDanhBa.ImageSize = new System.Drawing.Size(16, 16);
            this.imgDanhBa.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmDanhBa
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.trvDanhBa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDanhBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBTVN2";
            this.Load += new System.EventHandler(this.frmDanhBa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvDanhBa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imgDanhBa;
    }
}
