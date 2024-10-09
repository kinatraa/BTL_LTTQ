using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhuTungDAL
    {
        public List<PhuTungDTO> LayDanhSachPhuTung()
        {
            string query = "SELECT * FROM PhuTung";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            List<PhuTungDTO> dsPhuTung = new List<PhuTungDTO>();
            foreach (DataRow row in dataTable.Rows) 
            {
                PhuTungDTO phuTung = new PhuTungDTO
                {
                    MaPhuTung = row["MaPhuTung"].ToString(),
                    TenPhuTung = row["TenPhuTung"].ToString(),
                    SoLuong = int.Parse(row["SoLuong"].ToString()),
                    DonGiaBan = long.Parse(row["DonGiaBan"].ToString())
                };
                dsPhuTung.Add(phuTung);
            }

            return dsPhuTung;
        }
    }
}
