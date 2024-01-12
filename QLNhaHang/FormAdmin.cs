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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            billDTOBindingSource.DataSource = GetListBillByDate(dtpFromDate.Value, dtpToDate.Value);
            LoadListFood();
            LoadListCategory();
            LoadListTable();
            LoadListAccount();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        public List<BillDTO> GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            var dataContext = new RestaurantDB();
            var result = from b in dataContext.Bills
                         join t in dataContext.Table on b.TableID equals t.ID
                         where b.DateCheckIn >= checkIn && b.DateCheckOut <= checkOut && b.Status == 1
                         select new BillDTO
                         {
                             ID = b.ID,
                             TableName = t.TableNumber,
                             TotalPrice = b.TotalPrice,
                             DateCheckIn = b.DateCheckIn,
                             DateCheckOut = b.DateCheckOut,
                             Discount = b.Discount
                         };

            return result.ToList();
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            billDTOBindingSource.DataSource = GetListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        void LoadListFood()
        {
            var db = new RestaurantDB();
            var ls = db.Food
                .OrderBy(c => c.ID)
                .Select(c => new FoodDTO
                {
                    Id = c.ID,
                    Name = c.Name,
                    IdCategory = c.CategoryID,
                    Price = c.Price
                }).ToList();
            foodDTOBindingSource.DataSource = ls;

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var f = new FoodEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListFood();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            var selFood = foodDTOBindingSource.Current as FoodDTO;
            if (selFood != null)
            {
                var f = new FoodEdit(selFood);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListFood();
                }
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            var selFood = foodDTOBindingSource.Current as FoodDTO;
            if (selFood != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();

                    if (db.Bill_InFo.Where(b => b.FoodID == selFood.Id).FirstOrDefault() != null)
                    {
                        MessageBox.Show("Không được phép xóa.\nMón này đã có trong hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var obj = db.Food.Where(t => t.ID == selFood.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Food.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListFood();
                    }
                }
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            String key = txtSearchFood.Text;

            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new RestaurantDB();

            var result = db.Food.Where(f => f.Name.Contains(key) || f.ID.ToString().Contains(key)).Select(c => new FoodDTO
            {
                Id = c.ID,
                Name = c.Name,
                IdCategory = c.CategoryID,
                Price = c.Price
            }).ToList();

            foodDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnRefreshFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        void LoadListCategory()
        {
            var db = new RestaurantDB();
            var ls = db.FoodCategory
                .OrderBy(c => c.ID)
                .Select(c => new FoodCategoryDTO
                {
                    Id = c.ID,
                    FoodType = c.FoodType,
                }).ToList();
            foodCategoryDTOBindingSource.DataSource = ls;

        }

        private void btnAddFoodCat_Click(object sender, EventArgs e)
        {
            var f = new FoodCategoryEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListCategory();
            }
        }

        private void btnEditFoodCat_Click(object sender, EventArgs e)
        {
            var selCategoryFood = foodCategoryDTOBindingSource.Current as FoodCategoryDTO;
            if (selCategoryFood != null)
            {
                var f = new FoodCategoryEdit(selCategoryFood);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListCategory();
                }
            }
        }

        private void btnDeleteFoodCat_Click(object sender, EventArgs e)
        {
            var selCategoryFood = foodCategoryDTOBindingSource.Current as FoodCategoryDTO;
            if (selCategoryFood != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.FoodCategory.Where(t => t.ID == selCategoryFood.Id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.FoodCategory.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListCategory();
                    }
                }
            }
        }

        private void btnRefreshFoodCat_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnSearchFoodCat_Click(object sender, EventArgs e)
        {
            String key = txtSearchFoodCat.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new RestaurantDB();
            var result = db.FoodCategory.Where(fc => fc.FoodType.Contains(key) || fc.ID.ToString().Contains(key)).Select(c => new FoodCategoryDTO
            {
                Id = c.ID,
                FoodType = c.FoodType,
            }).ToList();

            foodCategoryDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void LoadListTable()
        {
            var db = new RestaurantDB();
            var ls = db.Table
                .OrderBy(c => c.ID)
                .Select(c => new TableDTO
                {
                    ID = c.ID,
                    TableNumber = c.TableNumber,
                    Status = c.status,
                }).ToList();
            tableDTOBindingSource.DataSource = ls;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            var f = new TableEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListTable();
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            var selTableFood = tableDTOBindingSource.Current as TableDTO;
            if (selTableFood != null)
            {
                var f = new TableEdit(selTableFood);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                    LoadListTable();
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            var selTableFood = tableDTOBindingSource.Current as TableDTO;
            if (selTableFood != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.Table.Where(t => t.ID == selTableFood.ID).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Table.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListTable();
                    }
                }
            }
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            String key = txtSearchTable.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new RestaurantDB();
            var result = db.Table.Where(fc => fc.TableNumber.Contains(key) || fc.ID.ToString().Contains(key)).Select(c => new TableDTO
            {
                ID = c.ID,
                TableNumber = c.TableNumber,
                Status = c.status,
            }).ToList();

            tableDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }
        void LoadListAccount()
        {
            var db = new RestaurantDB();
            var ls = db.Account
                .OrderBy(c => c.UserName)
                .Select(c => new AccountDTO
                {
                    UserName = c.UserName,
                    DisplayName = c.DisplayName,
                    Type = c.Type,
                }).ToList();
            accountDTOBindingSource.DataSource = ls;

        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var f = new AccountEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadListTable();
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var selAccount = tableDTOBindingSource.Current as AccountDTO;
            if (selAccount != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.Account.Where(t => t.UserName == selAccount.UserName).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Account.Remove(obj);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadListTable();
                    }
                }
            }
        }
        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            String key = txtAccount.Text;
            if (key.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var db = new RestaurantDB();
            var result = db.Account.Where(a => a.UserName.Contains(key) || a.DisplayName.Contains(key)).Select(a => new AccountDTO
            {
                UserName = a.UserName,
                DisplayName = a.DisplayName,
                Type = a.Type,
            }).ToList();

            accountDTOBindingSource.DataSource = result;

            if (result.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            var selAccount = accountDTOBindingSource.Current as AccountDTO;
            if (selAccount != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn đặt lại mật khẩu không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.Account.Where(a => a.UserName == selAccount.UserName).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Password = "123";
                        db.SaveChanges();
                        MessageBox.Show("Đặt lại mật khẩu thành công! Mật khẩu của bạn là userName của bạn!", "Thông báo", MessageBoxButtons.OK);
                        LoadListAccount();
                    }
                }
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            var f = new FormCountChart();
            f.ShowDialog();
        }
    }
}
