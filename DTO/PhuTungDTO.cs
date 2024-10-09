using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhuTungDTO
    {
        public string MaPhuTung { get; set; }
        public string TenPhuTung { get; set; }
        public int SoLuong { get; set; }
        public long DonGiaBan { get; set; }
    }
}
