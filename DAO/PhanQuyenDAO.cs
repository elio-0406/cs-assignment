using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhanQuyenDAO
    {
        public PhanQuyenDAO() { }

        public List<PhanQuyen> LayTatCaPhanQuyen()
        {
            List<PhanQuyen> listPhanQuyen = [];

            string query = "select * from PhanQuyen";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach(DataRow row in dataTable.Rows)
                {
                    PhanQuyen phanQuyen = new()
                    {
                        MaPhanQuyen = row["maPhanQuyen"].ToString(),
                        TenPhanQuyen = row["tenPhanQuyen"].ToString()
                    };
                    listPhanQuyen.Add(phanQuyen);
                }
            }

            return listPhanQuyen;
        }

        public List<PhanQuyen> TimKiemPhanQuyen(string tuKhoa, string maPhanQuyen)
        {
            List<PhanQuyen> listPhanQuyen = [];

            string query = "select * from PhanQuyen " +
                           "where (@tuKhoa = '' or maPhanQuyen like @tuKhoa " +
                           "or tenPhanQuyen collate Latin1_General_CI_AI like @tuKhoa) " +
                           "and (@maPhanQuyen = '' or maPhanQuyen = @maPhanQuyen)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maPhanQuyen", SqlDbType.Char) { Value = maPhanQuyen }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhanQuyen phanQuyen = new()
                    {
                        MaPhanQuyen = row["maPhanQuyen"].ToString(),
                        TenPhanQuyen = row["tenPhanQuyen"].ToString()
                    };
                    listPhanQuyen.Add(phanQuyen);
                }
            }

            return listPhanQuyen;
        }
    }
}
