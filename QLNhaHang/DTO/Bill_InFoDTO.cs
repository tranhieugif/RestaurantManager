using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class Bill_InFoDTO
    {
        public long ID { get; set; }

        public long Bill_ID { get; set; }

        public long FoodID { get; set; }

        public int Count { get; set; }
    }
}
