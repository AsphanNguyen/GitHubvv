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
    public partial class Frmlamthu : Form
    {
        public Frmlamthu()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
            }
            if (lst_box1.Items.IndexOf(txt_HoTen.Text) >=0 )
            {
                MessageBox.Show("Đã có rồi");
            }
            else
            {
                lst_box1.Items.Add(txt_HoTen.Text);
            }
        }

        private void btn_sangPhai_Click(object sender, EventArgs e)
        {
            if (lst_box1.Items.Count > 0)
            {
                lst_box2.Items.Add(lst_box1.Items[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
        }

        private void btn_allSangphai_Click(object sender, EventArgs e)
        {
            if (lst_box1.Items.Count > 0)
            {
                for(int i = lst_box1.Items.Count-1;i >= 0; i-- )
                {
                    lst_box2.Items.Add(lst_box1.Items[i]);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
        }

        private void cbb_Phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Frmlamthu_Load(object sender, EventArgs e)
        {
            cbb_Phongban.Items.Add("Phòng Nghiên cứu");
            cbb_Phongban.Items.Add("Phòng Quản lý");
        }
    }
}
