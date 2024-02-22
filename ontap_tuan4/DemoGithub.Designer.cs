namespace ontap_tuan4
{
    partial class DemoGithub
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
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lst_box1 = new System.Windows.Forms.ListBox();
            this.btn_sangphai = new System.Windows.Forms.Button();
            this.lst_box2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(85, 26);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(259, 26);
            this.txt_hoten.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(369, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 36);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lst_box1
            // 
            this.lst_box1.FormattingEnabled = true;
            this.lst_box1.ItemHeight = 20;
            this.lst_box1.Location = new System.Drawing.Point(29, 83);
            this.lst_box1.Name = "lst_box1";
            this.lst_box1.Size = new System.Drawing.Size(215, 224);
            this.lst_box1.TabIndex = 2;
            // 
            // btn_sangphai
            // 
            this.btn_sangphai.Location = new System.Drawing.Point(300, 83);
            this.btn_sangphai.Name = "btn_sangphai";
            this.btn_sangphai.Size = new System.Drawing.Size(75, 36);
            this.btn_sangphai.TabIndex = 1;
            this.btn_sangphai.Text = ">";
            this.btn_sangphai.UseVisualStyleBackColor = true;
            // 
            // lst_box2
            // 
            this.lst_box2.FormattingEnabled = true;
            this.lst_box2.ItemHeight = 20;
            this.lst_box2.Location = new System.Drawing.Point(424, 83);
            this.lst_box2.Name = "lst_box2";
            this.lst_box2.Size = new System.Drawing.Size(215, 224);
            this.lst_box2.TabIndex = 2;
            // 
            // DemoGithub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 363);
            this.Controls.Add(this.lst_box2);
            this.Controls.Add(this.lst_box1);
            this.Controls.Add(this.btn_sangphai);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_hoten);
            this.Name = "DemoGithub";
            this.Text = "DemoGithub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lst_box1;
        private System.Windows.Forms.Button btn_sangphai;
        private System.Windows.Forms.ListBox lst_box2;
    }
}