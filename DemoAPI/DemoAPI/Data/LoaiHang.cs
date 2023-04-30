using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI.Data
{
    [Table("LoaiHang")]
    public class LoaiHang
    {
        [Key]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
