using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class MenuDTO
    {
        public int Bill_InfoID { get; set; }    
        public string Name { get; set; }

        public int Count { get; set; }

        public float Price { get; set; }

        public float TotalPrice { get; set; }
    }
}
