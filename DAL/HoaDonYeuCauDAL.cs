using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL
{
    public class HoaDonYeuCauDAL
    {

        public bool ThemHoaDon(string MaHoaDon, string MaNhanVien, string MaPhuTung, string MaSuaChua,
            DateTime NgayIn, string GiaiPhap, int SoLuong, decimal TongTien)
        {
            string query = "exec addHoaDon @mahoadon , @manhanvien , @maphutung , @masuachua , @ngayin , @giaiphap , @soluong , @tongtien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {MaHoaDon,MaNhanVien,MaPhuTung,MaSuaChua,NgayIn,GiaiPhap,SoLuong,TongTien});
            return result > 0;

        }
        public string GetMaHoaDon(string MaSuaChua)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE MaSuaChua = @masuachua";

            // Thực hiện truy vấn và nhận kết quả
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { MaSuaChua });

            // Chuyển đổi kết quả sang string và kiểm tra null
            return result != null ? result.ToString() : null;
        }

        public List<HoaDonYeuCauDTO> GetListHoaDon()
        {
            string query = "select MaSuaChua, MaXe,YEUCAUSUACHUA.MaKhachHang,TenKhachHang from " +
                "YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<HoaDonYeuCauDTO> listYeuCau = new List<HoaDonYeuCauDTO>();
            foreach (DataRow row in data.Rows)
            {
                HoaDonYeuCauDTO hoaDonYeuCauDTO = new HoaDonYeuCauDTO(
                   
                    row["MaSuaChua"].ToString(),
                    row["MaXe"].ToString(),                  
                    row["MaKhachHang"].ToString(),
                    row["TenKhachHang"].ToString()
                    
                );
                listYeuCau.Add(hoaDonYeuCauDTO);
            }
            return listYeuCau;
        }
    }
}
