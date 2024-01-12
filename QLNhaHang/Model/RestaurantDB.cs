using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLNhaHang.Model
{
    public class RestaurantDB : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Bill_InFo> Bill_InFo { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Table> Table { get; set; }
        public string DbName = "Restaurant.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Application.StartupPath, DbName);
            optionsBuilder.UseSqlite($"Data source={path}");
        }
    }
}
