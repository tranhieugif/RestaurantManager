using QLNhaHang.DTO;
using QLNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang
{
    public partial class FoodEdit : Form
    {
        FoodDTO food;
        public FoodEdit(FoodDTO food = null)
        {
            InitializeComponent();
            this.food = food;
            LoadFoodCategory();
            //Đưa đồ cũ lên nếu cập nhật
            if (food != null)
            {
                var db = new RestaurantDB();
                this.Text = "Cập nhật thực đơn ";
                lblTitle.Text = "Cập nhật thực đơn";
                txtFoodID.Text = food.Id.ToString();
                txtFoodName.Text = food.Name;
                cmbFoodCategory.Text = db.FoodCategory.Where(fc => fc.ID == food.IdCategory).FirstOrDefault().FoodType;
                nmFoodPrice.Value = (int)food.Price;
            }
        }
        void LoadFoodCategory()
        {
            //Đổ dữ liệu danh mục lên cmbFoodCategory
            //B1: Lấy dữ liệu danh mục từ DB
            var db = new RestaurantDB();
            var ls = db.FoodCategory.OrderBy(c => c.ID)
                .Select(c => new FoodCategoryDTO
                {
                    Id = c.ID,
                    FoodType = c.FoodType,
                }).ToList();

            //B2: Đổ dữ liệu lên cmbFoodCategory
            cmbFoodCategory.DataSource = ls;
            cmbFoodCategory.DisplayMember = "FoodType";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var selFood = cmbFoodCategory.SelectedItem as FoodCategoryDTO;
            var db = new RestaurantDB();
            if (food == null)
            {
                //Thêm mới
                var obj = new Food
                {
                    Name = txtFoodName.Text,
                    CategoryID = selFood.Id,
                    Price = (long)nmFoodPrice.Value
                };
                db.Food.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.Food.Where(t => t.ID == food.Id).FirstOrDefault();
                obj.Name = txtFoodName.Text;
                obj.CategoryID = selFood.Id;
                obj.Price = (long)nmFoodPrice.Value;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
