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

        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            if (lstBox1.Items.Count > 0)
            {
                lstBox2.Items.Add(lstBox1.SelectedItem);
                
            }
            else
            {
                MessageBox.Show("Chua co Item nao");
            }
        }

        private void btnAllphai_Click(object sender, EventArgs e)
        {
            if (lstBox1.Items.Count > 0)
            {
                foreach (var item in lstBox1.Items)
                {
                    lstBox2.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Chua co Item nao");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            lstBox1.Items.RemoveAt(lstBox1.SelectedIndex);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOnTap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) { e.Cancel = true; }
        }
        //Đã nhận được
    }
}
