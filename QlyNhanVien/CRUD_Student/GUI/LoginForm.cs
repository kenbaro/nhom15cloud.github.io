using CRUD_Student.BUS;
using CRUD_Student.DTO;
using CRUD_Student.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login()
        {
            if (un_tbx.Text == "" || pw_tbx.Text == "")
            {
                MessageBox.Show("UserName or PassWord Mustn't Be Empty", "Login ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable _ds = NhanVienBUS.LayDSNhanVienCoMK();
                bool flag = false;
                for (int i = 0; i < _ds.Rows.Count; i++)
                {
                    if (un_tbx.Text == _ds.Rows[i]["TenDN"].ToString() && pw_tbx.Text == _ds.Rows[i]["MatKhau"].ToString())
                    {
                        NhanVienManagement mnFrm = new NhanVienManagement();
                        mnFrm.Nv = new NhanVienDTO(int.Parse(_ds.Rows[i]["MaNV"].ToString()), _ds.Rows[i]["HoTen"].ToString(), _ds.Rows[i]["TenDN"].ToString(), _ds.Rows[i]["MatKhau"].ToString(), _ds.Rows[i]["Quyen"].ToString());
                        mnFrm.Show();
                        flag = true;
                        //txbUser.Text = "";
                        //txbPass.Text = "";
                        //radManager.Checked = false;
                        this.Hide();
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng", "Lỗi Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pw_tbx.Text = "";
                    pw_tbx.Focus();
                }
            }
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
