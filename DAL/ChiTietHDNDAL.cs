using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietHDNDAL
    {
        public bool ThemChiTietHDN(ChiTietHDNDTO chiTietHDN) {
            string query = "INSERT INTO CHITIETHDN (MaHDN, MaPhuTung, SoLuongNhap) VALUES ( @maHDN , @maPhuTung , @soLuongNhap )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { chiTietHDN.MaHDN, chiTietHDN.MaPhuTung, chiTietHDN.SoLuongNhap });
            return result > 0;
        }
    }
}
