using CRUD_Student.DAO;
using CRUD_Student.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Student.BUS
{
    public class PhanCongBUS
    {
        public static DataTable LayDSPhanCong()
        {
            DataTable dt = PhanCongDAO.LayDSPhanCong();
            return dt;
        }
        public static bool ThemPhanCong(PhanCongDTO pc)
        {
            bool kq = PhanCongDAO.ThemPhanCong(pc);
            return kq;
        }
        public static bool XoaPhanCong(PhanCongDTO pc)
        {
            bool kq = PhanCongDAO.XoaPhanCong(pc);
            return kq;
        }

        public static int LayMaNVTheoMaBanVaCa(int maBan, int ca)
        {
            int maNV = PhanCongDAO.LayMaNVTheoMaBanVaCa(maBan, ca);
            return maNV;
        }

        public static int LayCaTheoGio(int gio)
        {
            int ca = PhanCongDAO.LayCaTheoGio(gio);
            return ca;
        }

    }
}
