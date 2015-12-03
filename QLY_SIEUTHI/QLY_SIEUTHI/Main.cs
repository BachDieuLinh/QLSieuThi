using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLY_SIEUTHI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void danhSachMătHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmLoaiHang frm = new frmLoaiHang();
            frm.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void hóaĐơnBánKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Warn!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void phiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }



        private void statisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
