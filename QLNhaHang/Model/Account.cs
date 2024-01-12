using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public int Type { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
    }
}
