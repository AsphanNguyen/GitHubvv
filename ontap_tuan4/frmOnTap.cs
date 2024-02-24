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
    public partial class frmOnTap : Form
    {
        public frmOnTap()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui long nhap ten");
            }
            if (lstBox1.Items.IndexOf(txtName.Text) >= 0)
            {
                MessageBox.Show("Da co");
            }
            else
            {
                lstBox1.Items.Add(txtName.Text);
            }
        }
    }
}
