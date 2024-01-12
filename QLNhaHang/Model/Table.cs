using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Model
{
    [Table("Table")]
    public class Table
    {
        [Key]
        public int ID {  get; set; }
        public string TableNumber { get; set; }
        public string status { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
    }
}
