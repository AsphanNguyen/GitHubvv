namespace ontap_tuan4
{
    partial class Form1
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
            this.btn_addname = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_title = new System.Windows.Forms.ComboBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lst_content = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_addname
            // 
            this.btn_addname.Location = new System.Drawing.Point(43, 32);
            this.btn_addname.Name = "btn_addname";
            this.btn_addname.Size = new System.Drawing.Size(134, 45);
            this.btn_addname.TabIndex = 0;
            this.btn_addname.Text = "Add name";
            this.btn_addname.UseVisualStyleBackColor = true;
            this.btn_addname.Click += new System.EventHandler(this.btn_addname_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(518, 32);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 45);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // cbb_title
            // 
            this.cbb_title.FormattingEnabled = true;
            this.cbb_title.Location = new System.Drawing.Point(43, 155);
            this.cbb_title.Name = "cbb_title";
            this.cbb_title.Size = new System.Drawing.Size(102, 28);
            this.cbb_title.TabIndex = 3;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(225, 157);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(157, 26);
            this.txt_firstname.TabIndex = 4;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(480, 157);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(152, 26);
            this.txt_lastname.TabIndex = 4;
            // 
            // lst_content
            // 
            this.lst_content.FormattingEnabled = true;
            this.lst_content.ItemHeight = 20;
            this.lst_content.Location = new System.Drawing.Point(43, 213);
            this.lst_content.Name = "lst_content";
            this.lst_content.Size = new System.Drawing.Size(589, 144);
            this.lst_content.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 372);
            this.Controls.Add(this.lst_content);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.cbb_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_addname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addname;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_title;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.ListBox lst_content;
    }
}

