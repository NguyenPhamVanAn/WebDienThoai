using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Hoa
    {
        public int MaHoa { get; set; }
        public string TenHoa { get; set; }
        public double Gia { get; set; }
        public string Hinh { get; set; }
        public int? MaLoai { get; set; }
        public DateTime? NgayDang { get; set; }
        public int? SoLuotXem { get; set; }

        public virtual Loai MaLoaiNavigation { get; set; }
    }
}
