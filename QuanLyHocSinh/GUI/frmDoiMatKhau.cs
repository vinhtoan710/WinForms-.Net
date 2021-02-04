using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLy.GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {

        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnOK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int ketqua = 0;
            string sql = "select * from TAIKHOAN where TENTAIKHOAN='"+txtTK.Text+"'";

            DataTable dt = lop.LoadData(sql);

            DataRow dr = dt.Rows[0];
            string passwordCu = Convert.ToString(dr["MATKHAU"]);

            if (passwordCu == txtMkCu.Text)
            {
                string sql1 = "Update TAIKHOAN set MATKHAU='" + txtMkMoi.Text + "' where TENTAIKHOAN='"+txtTK.Text+"'";
                ketqua = lop.ExecuteNonquery(sql1);
                if (ketqua > 0)
                {
                    MessageBox.Show("Password change successfull");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password change failed");
                }
            }
            else
            {
                MessageBox.Show("Your old password was wrong");
            }

            

            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}