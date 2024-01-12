using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Model
{
    [Table("FoodCategory")]
    public class FoodCategory
    {
        [Key]
        public int ID { get; set; }
        public string FoodType { get; set; }
        public virtual ICollection<Food> Food { get; set; }
    }
}
