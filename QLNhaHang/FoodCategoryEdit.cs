using QLNhaHang.DTO;
using QLNhaHang.Migrations;
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
    public partial class FoodCategoryEdit : Form
    {
        FoodCategoryDTO foodCategory;
        public FoodCategoryEdit(FoodCategoryDTO foodCategory = null)
        {
            InitializeComponent();
            this.foodCategory = foodCategory;
            //Đưa đồ cũ lên nếu cập nhật
            if (foodCategory != null)
            {
                var db = new RestaurantDB();
                this.Text = "Cập nhật danh mục";
                lblTitle.Text = "Cập nhật danh mục";
                txtCategoryID.Text = foodCategory.Id.ToString();
                txtCategoryName.Text = foodCategory.FoodType;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var db = new RestaurantDB();
            if (foodCategory == null)
            {
                //Thêm mới
                var obj = new FoodCategory
                {
                    FoodType = txtCategoryName.Text,
                };
                db.FoodCategory.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.FoodCategory.Where(t => t.ID == foodCategory.Id).FirstOrDefault();
                obj.FoodType = txtCategoryName.Text;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
