namespace ontap_tuan4
{
    partial class frmOnTap
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.btnAllphai = new System.Windows.Forms.Button();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(48, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 26);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(343, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBox1
            // 
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.ItemHeight = 20;
            this.lstBox1.Location = new System.Drawing.Point(12, 83);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(282, 364);
            this.lstBox1.TabIndex = 2;
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.Location = new System.Drawing.Point(343, 112);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(84, 35);
            this.btnSangPhai.TabIndex = 1;
            this.btnSangPhai.Text = ">";
            this.btnSangPhai.UseVisualStyleBackColor = true;
            this.btnSangPhai.Click += new System.EventHandler(this.btnSangPhai_Click);
            // 
            // btnAllphai
            // 
            this.btnAllphai.Location = new System.Drawing.Point(343, 181);
            this.btnAllphai.Name = "btnAllphai";
            this.btnAllphai.Size = new System.Drawing.Size(84, 35);
            this.btnAllphai.TabIndex = 1;
            this.btnAllphai.Text = ">>";
            this.btnAllphai.UseVisualStyleBackColor = true;
            this.btnAllphai.Click += new System.EventHandler(this.btnAllphai_Click);
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.ItemHeight = 20;
            this.lstBox2.Location = new System.Drawing.Point(506, 83);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(282, 364);
            this.lstBox2.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 54);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(628, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmOnTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox1);
            this.Controls.Add(this.btnAllphai);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Name = "frmOnTap";
            this.Text = "frmOnTap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOnTap_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Button btnAllphai;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}