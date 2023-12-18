using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO phanQuyenDAO;

        public PhanQuyenBUS() 
        { 
            phanQuyenDAO = new PhanQuyenDAO();
        }

        public List<PhanQuyen> LayTatCaPhanQuyen()
        {
            return phanQuyenDAO.LayTatCaPhanQuyen();
        }

        public List<PhanQuyen> TimKiemPhanQuyen(string tuKhoa, string maPhanQuyen)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return phanQuyenDAO.TimKiemPhanQuyen(tuKhoa, maPhanQuyen);
        }
    }
}
