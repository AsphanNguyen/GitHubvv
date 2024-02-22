using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontap_tuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_title.Items.Add("Dr");
            cbb_title.Items.Add("Mr");
            cbb_title.Items.Add("Mrs");
            cbb_title.Items.Add("Miss");
        }

        private void btn_addname_Click(object sender, EventArgs e)
        {
            if ( cbb_title.SelectedIndex == -1 || txt_firstname.Text.Trim() == "" || txt_lastname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ ký tự");
            }
            else
            {
                lst_content.Items.Add(cbb_title.Text + ". " + txt_firstname.Text + " " + txt_lastname.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) { e.Cancel = true; }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
