using CRUD_Student.BUS;
using CRUD_Student.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Student.GUI
{
    public partial class NhanVienManagement : Form
    {
        public NhanVienManagement()
        {
            InitializeComponent();
            tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
        }

        private NhanVienDTO _nv = new NhanVienDTO();
        public NhanVienDTO Nv
        {
            get { return _nv; }
            set { _nv = value; }
        }
    /*    void HienThiDanhSachNhanVien() {
            DataTable dt = new DataTable();
            if (_nv.Quyen == "Admin")
            {
               dt = NhanVienBUS.LayDSNhanVienCoMK();
                dgv_NhanVien.DataSource = dt;
            }
            else {
                dt = NhanVienBUS.LayDSNhanVien();
                dgv_NhanVien.DataSource = dt;
            }
        }
        void HienThiDanhSachPhanCong() {
            DataTable dt = PhanCongBUS.LayDSPhanCong();
            dgvDSPhanCong.DataSource = dt;

        }*/
        private void NhanVienManagement_Load(object sender, EventArgs e)
        {

            /* HienThiDanhSachNhanVien();
             HienThiDanhSachPhanCong();*/
            
            LoadThongTinNguoiDung();
            DuaDSNhanVienLenDataGridView();
            DuaBanPhanCongLenCombobox();
            DuaDanhSachPhanCongLenDataGridView();
            LoadNhanVienPhanCongLenCombobox();
        }

        public void LoadNhanVienPhanCongLenCombobox()
        {
            DataTable dt = NhanVienBUS.LayDSNhanVienTiepTan();
            cmbNhanVienpc.DataSource = dt;
            cmbNhanVienpc.DisplayMember = "HoTen";
            cmbNhanVienpc.ValueMember = "MaNV";
        }
        public void DuaDanhSachPhanCongLenDataGridView()
        {
            DataTable dt = PhanCongBUS.LayDSPhanCong();
            dgvDSPhanCong.DataSource = dt;
        }
        private void LoadThongTinNguoiDung()
        {
            TenDN.Text = Nv.TenDN.ToString();
            hoTen.Text = Nv.HoTen.ToString();
            quyen.Text = Nv.Quyen.ToString();
        }
        public void DuaDSNhanVienLenDataGridView()
        {
            DataTable _dsnd = NhanVienBUS.LayDSNhanVien();
            dgv_NhanVien.DataSource = _dsnd;
        }
        public void DuaBanPhanCongLenCombobox()
        {
            List<BanDTO> dt = new List<BanDTO>();
            dt = BanBUS.LayDSBan();
            cmbBanPC.DataSource = dt;
            cmbBanPC.DisplayMember = "MaBan";
            cmbBanPC.ValueMember = "MaBan";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //---------------------------- Nhan Vien -----------------------------//
        public void ThemNhanVien()
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.HoTen = tbx_DisplName.Text;
            nv.TenDN = tbx_User.Text;
            nv.MatKhau = tbx_Pass.Text;
            nv.Quyen = cmB_Type.Text;
            if (!NhanVienBUS.KiemTraTenDNTonTai(nv.TenDN, nv.MaNV))
            {
                bool kq = NhanVienBUS.ThemNhanVien(nv);
                if (kq == true)
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DuaDSNhanVienLenDataGridView();
                    tbx_User.Text = "";
                    tbx_Pass.Text = "";
                    tbx_Repass.Text = "";
                    tbx_DisplName.Text = "";
                    cmB_Type.Text = "Tiep Tan";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private bool verify()
        {
            if (tbx_User.Text == "" || tbx_Pass.Text == "" || tbx_Repass.Text == "" || tbx_DisplName.Text == "" || cmB_Type.Text == "")
            {
                return false;
            }
            else return true;
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
                ThemNhanVien();
            else
                MessageBox.Show("Chỉ có Quản Lý mới được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_DSNV_Click(object sender, EventArgs e)
        {
            HienThiDSNV();
        }
        private void HienThiDSNV()
        {
            if (_nv.Quyen != "Admin")
            {
                DataTable dt = NhanVienBUS.LayDSNhanVien();
                dgv_NhanVien.DataSource = dt;
            }
            else
            {
                DataTable dt = NhanVienBUS.LayDSNhanVienCoMK();
                dgv_NhanVien.DataSource = dt;
            }
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                int index = dgv_NhanVien.CurrentRow.Index;
                int maNV = int.Parse(dgv_NhanVien.Rows[index].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    string quyen = NhanVienBUS.LayQuyenNVTheoMaNV(maNV);
                    if (quyen != "Admin")
                    {
                        bool kq;
                        try
                        {
                            kq = NhanVienBUS.XoaNhanVien(maNV);
                            if (kq == true)
                            {
                                MessageBox.Show("Đã xóa nhân viên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DuaDSNhanVienLenDataGridView();
                                tbx_User.Text = "";
                                tbx_Pass.Text = "";
                                tbx_Repass.Text = "";
                                tbx_DisplName.Text = "";
                            }
                            else
                                MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch
                        {
                            MessageBox.Show("Nhân viên đang được phân công không thể xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Không thể xóa tài khoản Admin!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SearchNV_Click(object sender, EventArgs e)
        {
            if (tbx_Search.Text == "")
            {
                MessageBox.Show("Chưa Nhập Tên Cần Tra Cứu ! ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tbx_DisplName.Text = "";
                tbx_User.Text = "";
                tbx_Repass.Text = "";
                tbx_Pass.Text = "";
                cmB_Type.Text = "Tiep Tan";
                DataTable dt = NhanVienBUS.TraCuuNhanVienTheoTen(tbx_Search.Text);
                dgv_NhanVien.DataSource = dt;
            }
        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                int idx = dgv_NhanVien.CurrentRow.Index;
                tbx_DisplName.Text = dgv_NhanVien.Rows[idx].Cells[1].Value.ToString();
                tbx_User.Text = dgv_NhanVien.Rows[idx].Cells[2].Value.ToString();
                cmB_Type.Text = dgv_NhanVien.Rows[idx].Cells[3].Value.ToString();
                if (cmB_Type.Text == "Admin")
                {
                    tbx_User.ReadOnly = false;
                    tbx_Pass.ReadOnly = false;
                    tbx_Repass.ReadOnly = false;
                    cmB_Type.Enabled = false;
                }
                else
                    cmB_Type.Enabled = true;
                string MatKhau = NhanVienBUS.LayMatKhauTuTenDN(dgv_NhanVien.Rows[idx].Cells[2].Value.ToString());
                tbx_Pass.Text = MatKhau;
                tbx_Repass.Text = tbx_Pass.Text;
            }
        }

        public void SuaNhanVien()
        {
            NhanVienDTO nv = new NhanVienDTO();
            int idx = dgv_NhanVien.CurrentRow.Index;
            nv.MaNV = int.Parse(dgv_NhanVien.Rows[idx].Cells[0].Value.ToString());
            nv.HoTen = tbx_DisplName.Text;
            nv.TenDN = tbx_User.Text;
            nv.MatKhau = tbx_Pass.Text;
            nv.Quyen = cmB_Type.Text;
            if (!NhanVienBUS.KiemTraTenDNTonTai(nv.TenDN, nv.MaNV))
            {
                bool kq = NhanVienBUS.CapNhatNhanVien(nv);
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công!");
                    DuaDSNhanVienLenDataGridView();
                    tbx_User.Text = "";
                    tbx_Pass.Text = "";
                    tbx_Repass.Text = "";
                    tbx_DisplName.Text = "";
                    cmB_Type.Text = "Tiep Tan";
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
                MessageBox.Show("Tên đăng nhập này đã tồn tại!");
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (_nv.Quyen == "Admin")
            {
                if (cmB_Type.Text != "Tiep Tan")
                {
                    if (tbx_User.Text.Length >= 6 && tbx_User.Text.Length <= 20)
                    {
                        if (tbx_DisplName.Text != "")
                        {
                            if (tbx_Pass.Text.Length >= 6 && tbx_Pass.Text.Length <= 20)
                            {
                                if (tbx_Pass.Text == tbx_Repass.Text)
                                {
                                        SuaNhanVien();
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu không trùng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbx_Repass.Text = "";
                                    tbx_Repass.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbx_Pass.Text = "";
                                tbx_Pass.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Họ tên nhân viên không được rỗng!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbx_DisplName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên Đăng nhập phải lớn hơn 5 và nhỏ hơn 21 ký tự!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbx_User.Text = "";
                        tbx_User.Focus();
                    }
                }
                else
                {
                    if (tbx_DisplName.Text != "")
                    {
                            SuaNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Họ tên nhân viên không được rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ có Admin mới có thể sử dụng chức năng này!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
