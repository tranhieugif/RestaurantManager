using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Model
{
    [Table("Food")]
    public class Food
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<Bill_InFo> Bill_InFo { get; set; }
    }
}
