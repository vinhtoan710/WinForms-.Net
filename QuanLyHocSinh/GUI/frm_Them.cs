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
    public partial class frm_Them : DevExpress.XtraEditors.XtraForm
    {
        BLL.GiangVien bllGV;
        GUI.frmDSHocSinh frmDSHocSinh;
        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();


        public void LoadCombobox()
        {
            string sql = "select * from LOP";
            DataTable dt = lop.LoadData(sql);
            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "TENLOP";
            cbMaLop.ValueMember = "MALOP";
        }
        public frm_Them()
        {
            InitializeComponent();
            frmDSHocSinh = new GUI.frmDSHocSinh();
            bllGV = new BLL.GiangVien(this);
        }

        

        private void frm_Them_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            
        }

        internal static string GetNameFromPath(string PathGoc)
        {
            return PathGoc.Substring(PathGoc.LastIndexOf(@"\")+1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hay chon anh";
            open.Filter = "JEPG|*.JEPG|BMP|*.bmp|Tất cả ảnh|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            txtHinh.Text = GetNameFromPath(open.FileName);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            bllGV.Them();
            this.Close();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



    }
}