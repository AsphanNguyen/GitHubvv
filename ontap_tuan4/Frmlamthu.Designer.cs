namespace ontap_tuan4
{
    partial class Frmlamthu
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
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lst_box1 = new System.Windows.Forms.ListBox();
            this.btn_sangPhai = new System.Windows.Forms.Button();
            this.lst_box2 = new System.Windows.Forms.ListBox();
            this.btn_allSangphai = new System.Windows.Forms.Button();
            this.cbb_Phongban = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(125, 30);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(272, 26);
            this.txt_HoTen.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(415, 20);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 36);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lst_box1
            // 
            this.lst_box1.FormattingEnabled = true;
            this.lst_box1.ItemHeight = 20;
            this.lst_box1.Location = new System.Drawing.Point(29, 76);
            this.lst_box1.Name = "lst_box1";
            this.lst_box1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_box1.Size = new System.Drawing.Size(239, 224);
            this.lst_box1.TabIndex = 2;
            // 
            // btn_sangPhai
            // 
            this.btn_sangPhai.Location = new System.Drawing.Point(322, 76);
            this.btn_sangPhai.Name = "btn_sangPhai";
            this.btn_sangPhai.Size = new System.Drawing.Size(75, 52);
            this.btn_sangPhai.TabIndex = 3;
            this.btn_sangPhai.Text = ">";
            this.btn_sangPhai.UseVisualStyleBackColor = true;
            this.btn_sangPhai.Click += new System.EventHandler(this.btn_sangPhai_Click);
            // 
            // lst_box2
            // 
            this.lst_box2.FormattingEnabled = true;
            this.lst_box2.ItemHeight = 20;
            this.lst_box2.Location = new System.Drawing.Point(437, 76);
            this.lst_box2.Name = "lst_box2";
            this.lst_box2.Size = new System.Drawing.Size(334, 224);
            this.lst_box2.TabIndex = 2;
            // 
            // btn_allSangphai
            // 
            this.btn_allSangphai.Location = new System.Drawing.Point(322, 166);
            this.btn_allSangphai.Name = "btn_allSangphai";
            this.btn_allSangphai.Size = new System.Drawing.Size(75, 45);
            this.btn_allSangphai.TabIndex = 4;
            this.btn_allSangphai.Text = ">>";
            this.btn_allSangphai.UseVisualStyleBackColor = true;
            this.btn_allSangphai.Click += new System.EventHandler(this.btn_allSangphai_Click);
            // 
            // cbb_Phongban
            // 
            this.cbb_Phongban.FormattingEnabled = true;
            this.cbb_Phongban.Location = new System.Drawing.Point(274, 239);
            this.cbb_Phongban.Name = "cbb_Phongban";
            this.cbb_Phongban.Size = new System.Drawing.Size(157, 28);
            this.cbb_Phongban.TabIndex = 5;
            this.cbb_Phongban.SelectedIndexChanged += new System.EventHandler(this.cbb_Phongban_SelectedIndexChanged);
            // 
            // Frmlamthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 329);
            this.Controls.Add(this.cbb_Phongban);
            this.Controls.Add(this.btn_allSangphai);
            this.Controls.Add(this.btn_sangPhai);
            this.Controls.Add(this.lst_box2);
            this.Controls.Add(this.lst_box1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_HoTen);
            this.Name = "Frmlamthu";
            this.Text = "Frmlamthu";
            this.Load += new System.EventHandler(this.Frmlamthu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lst_box1;
        private System.Windows.Forms.Button btn_sangPhai;
        private System.Windows.Forms.ListBox lst_box2;
        private System.Windows.Forms.Button btn_allSangphai;
        private System.Windows.Forms.ComboBox cbb_Phongban;
    }
}