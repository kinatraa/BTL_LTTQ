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
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { (object)MaHoaDon ?? DBNull.Value,MaNhanVien,MaPhuTung
                ,MaSuaChua,NgayIn,GiaiPhap,SoLuong,TongTien});
            return result > 0;

        }
        public string GetMaHoaDon(string MaSuaChua)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE MaSuaChua = @masuachua ";

            // Sử dụng ExecuteQuery để lấy kết quả dưới dạng DataTable
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSuaChua });

            if (dataTable.Rows.Count > 0) // Nếu có bản ghi
            {
                DataRow row = dataTable.Rows[0]; // Lấy hàng đầu tiên
                return row["MaHoaDon"].ToString(); // Trả về giá trị MaHoaDon
            }

            return null; // Trả về null nếu không tìm thấy bản ghi
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
