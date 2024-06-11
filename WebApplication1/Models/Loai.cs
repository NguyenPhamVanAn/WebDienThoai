using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Loai
    {
        public Loai()
        {
            Hoas = new HashSet<Hoa>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Hoa> Hoas { get; set; }
    }
}
