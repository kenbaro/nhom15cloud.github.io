using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Student.DTO
{
    public class NhanVienDTO
    {

        private int _maNV;
        private string _hoTen;
        private string _tenDN;
        private string _matKhau;
        private string _quyen;

        //Phương thức khởi tạo mặc định
        public NhanVienDTO()
        {
            _maNV = 0;
            _hoTen = "";
            _tenDN = "";
            _matKhau = "";
            _quyen = "";
        }

        //Phương thức khởi tạo có tham số
        public NhanVienDTO(int maNV, string hoTen, string tenDN, string matKhau, string quyen)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _tenDN = tenDN;
            _matKhau = matKhau;
            _quyen = quyen;

        }

        //Phương thức khởi tạo sao chép.
        public NhanVienDTO(NhanVienDTO nhanVien)
        {
            _maNV = nhanVien._maNV;
            _hoTen = nhanVien._hoTen;
            _tenDN = nhanVien._tenDN;
            _matKhau = nhanVien._matKhau;
            _quyen = nhanVien._quyen;
        }

        //Properties
        public int MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }


        public string TenDN
        {
            get { return _tenDN; }
            set { _tenDN = value; }
        }
        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        public string Quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }



    }
}
