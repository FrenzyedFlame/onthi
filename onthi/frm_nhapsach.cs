using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthi
{
    public partial class frm_nhapsach : Form
    {
        lopchung lc = new lopchung();
        public frm_nhapsach()
        {
            InitializeComponent();
        }

        private void frm_nhapsach_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadSach();
            load_TimKiem();
        }
        public void LoadTheLoai()
        {
            string sql1 = "Select * from THELOAI";
            DataTable dt2 = lc.LoadDL(sql1);
            cb_tl.DataSource = dt2;
            cb_tl.DisplayMember = "TENTHELOAI";
            cb_tl.ValueMember = "MATHELOAI";
        }

        public void LoadSach()
        {
            //string sql = "Select MaSach, TenSach, SoLuong, GiaBan, TenTacGia, TenNXB, TenTheLoai from Sach join TheLoai on Sach.MaTheLoai = TheLoai.MaTheLoai join TacGia on Sach.MaTacGia = TacGia.MaTacGia join NhaXuatBan on Sach.MaNXB = NhaXuatBan.MaNXB";
            //DataTable dt = lopchung.LoadDL(sql);
            //dtgv_sach.DataSource = dt;
            string sql = "Select * from SACH";
            DataTable dt = lc.LoadDL(sql);
            dt_sach.DataSource = dt;

        }

        private void dt_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dt_sach.CurrentRow.Cells["MASACH"].Value.ToString();
            txt_sotrang.Text = dt_sach.CurrentRow.Cells["SOTRANG"].Value.ToString();
            txt_tt.Text = dt_sach.CurrentRow.Cells["TOMTAT"].Value.ToString();
            txt_ten.Text = dt_sach.CurrentRow.Cells["TENSACH"].Value.ToString();
            cb_tl.SelectedValue = dt_sach.CurrentRow.Cells["MATHELOAI"].Value.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Sach values ('" + txt_id.Text + "',N'" + cb_tl.SelectedValue + "',N'" + txt_ten.Text + "',N'" + txt_sotrang.Text + "', N'" + txt_tt.Text + "' )";
            int kq = lc.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm sách thành công");
            else MessageBox.Show("Thêm sách thất bại");
            LoadSach();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SACH WHERE MASACH = '" + txt_id.Text + "'";
            int kq = lc.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa sách thành công");
            else MessageBox.Show("Xóa sách thất bại");
            LoadSach();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SACH SET TENSACH = '" + txt_ten.Text +
                 "', SOTRANG = '" + txt_sotrang.Text +
                 "', MATHELOAI = '" + cb_tl.SelectedValue +
                 "' WHERE MASACH = '" + txt_id.Text + "'";
            int kq = lc.themsuaxoa(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật sách thành công");
            else
                MessageBox.Show("Cập nhật sách thất bại");
            LoadSach();
        }
        public void load_TimKiem()
        {
            string sql = "Select * from SACH where TENSACH like '%" + txt_search.Text + "%'";
            DataTable dt = lc.LoadDL(sql);
            dt_sach.DataSource = dt;

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            load_TimKiem();
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from SACH";
            int kq = (int)lc.laygt(sql);
            txt_count.Text = kq.ToString();
        }
    }
}
