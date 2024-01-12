using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Model
{
    [Table("Bill_InFo")]
    public class Bill_InFo
    {
        [Key]
        public int ID { get; set; }
        public int Count { get; set; }
        public int Bill_ID { get; set; }
        [ForeignKey(nameof(Bill_ID))]
        public virtual Bill Bill { get; set; }
        public int FoodID { get; set; }
        [ForeignKey(nameof(FoodID))]
        public virtual Food Food { get; set; }
 
    }  
}
