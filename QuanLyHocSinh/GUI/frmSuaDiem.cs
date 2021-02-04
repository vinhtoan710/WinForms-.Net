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
    public partial class frmSuaDiem : DevExpress.XtraEditors.XtraForm
    {
        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();


        public frmSuaDiem()
        {
            InitializeComponent();
        }

        private void frmSuaDiem_Load(object sender, EventArgs e)
        {
           
        }
        public double trungbinh()
        {
            int chuyencan = int.Parse(txtChuyenCan.Text);
            int giuaki = int.Parse(txtGiuaKi.Text);
            int cuoiki = int.Parse(txtCuoiKi.Text);
            return (chuyencan + cuoiki + giuaki) / 3;
        }
        private void btnSuaDiem_Click(object sender, EventArgs e)
        {

            double tb = trungbinh();
            txtTBM.Text = tb.ToString();

            string sql = "update DIEM set  DIEMCHUYENCAN='"+txtChuyenCan.Text +"',DIEMGIUAKI='"+txtGiuaKi.Text+"',DIEMCUOIKI='"+txtCuoiKi.Text+"',TBM='"+txtTBM.Text+"' where MAHS='"+txtMaHS.Text+"' AND MALOP='"+txtMaLop.Text+"'";
            int ketqua = lop.ExecuteNonquery(sql);
            if (ketqua >= 0)
            {
                MessageBox.Show("Sửa điểm thành công");
            }
            else
            {
                MessageBox.Show("Sửa điểm thất bại");
            }
        }
    }
}