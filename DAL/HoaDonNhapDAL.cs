using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonNhapDAL
    {
        public List<HoaDonNhapDTO> LayHoaDonNhap()
        {           
            string query = "SELECT * FROM HOADONNHAPPHUTUNG";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            List<HoaDonNhapDTO> listHoaDon = new List<HoaDonNhapDTO>();
            foreach (DataRow row in dataTable.Rows) {
                HoaDonNhapDTO dto = new HoaDonNhapDTO()
                {
                    MaHDN = row["MaHDN"].ToString(),
                    MaNV = row["MaNhanVien"].ToString(),
                    NgayNhap = DateTime.Parse(row["NgayNhap"].ToString()),
                    TongTien = decimal.TryParse(row["TongTien"].ToString(), out decimal donGiaNhapValue) ? donGiaNhapValue : 0
                };
                listHoaDon.Add(dto);
            }  
            return listHoaDon;
        }
    }
}
