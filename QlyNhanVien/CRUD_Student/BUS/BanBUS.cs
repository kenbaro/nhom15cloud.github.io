using CRUD_Student.DAO;
using CRUD_Student.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Student.BUS
{
    public class BanBUS
    {
        public static List<BanDTO> LayDSBan()
        {
            List<BanDTO> _ds;
            _ds = BanDAO.LayDSBan();
            return _ds;
        }
    }
}
