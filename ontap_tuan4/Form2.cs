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
    public partial class frm_demo2 : Form
    {
        public frm_demo2()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ( lst_content.Items.IndexOf(txt_hoten.Text) >= 0)
            {
                lst_content.SelectedItem=txt_hoten.Text;
            }
            else
            {
                lst_content.Items.Add(txt_hoten.Text);
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lst_content.Items.Count > 0)
            {
                //lst_content.Items.Remove(lst_content.SelectedItems[0]);
                lst_content.Items.RemoveAt(lst_content.SelectedIndex);
            }
        }

        private void lst_content_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
