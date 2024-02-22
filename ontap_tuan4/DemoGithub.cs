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
    public partial class DemoGithub : Form
    {
        public DemoGithub()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
            }
            else
            { 
                lst_box1.Items.Add(txt_hoten.Text);
            }
        }

        private void btn_sangphai_Click(object sender, EventArgs e)
        {
            if (lst_box1.Items.Count > 0)
            {
                lst_box2.Items.Add(lst_box1.SelectedItem);
                //hahahaha
            }
        }
    }
}
