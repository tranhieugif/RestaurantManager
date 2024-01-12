using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Model
{
    [Table("Bill")]
    public class Bill
    {
        [Key]
        public int ID { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }
        public float TotalPrice { get; set; }
        public string Username { get; set; }
        [ForeignKey(nameof(Username))]
        public virtual Account Account { get; set; }
        public int TableID { get; set; }
        [ForeignKey(nameof(TableID))]
        public virtual Table Table { get; set; }
        public virtual ICollection<Bill_InFo> Bill_InFo { get; set; }
    }
}
