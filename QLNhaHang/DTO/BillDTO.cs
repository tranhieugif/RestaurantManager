using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class BillDTO
    {
        public int ID { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public string TableName { get; set; }
        public int Discount { get; set; }
        public int Status { get; set; }
        public float TotalPrice { get; set; }
        public string UserName { get; set; }
    }
}
