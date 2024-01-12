using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QLNhaHang.DTO;
using QLNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNhaHang
{
    public partial class FormManageTable : Form
    {
        AccountDTO account;
        public FormManageTable(AccountDTO account)
        {
            InitializeComponent();
            this.account = account;
            adminToolStripMenuItem.Enabled = account.Type == 1;
            LoadTable();
            LoadFoodCategory();
            LoadTableToCbb();
        }
        void LoadTable()

        {
            flpTable.Controls.Clear();

            var db = new RestaurantDB();

            var tableList = db.Table.OrderBy(c => c.ID)
                .Select(c => new TableDTO
                {
                    ID = c.ID,
                    TableNumber = c.TableNumber,
                    Status = c.status,
                }).ToList();

            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = 130, Height = 130 };
                btn.Text = "Bàn " + item.TableNumber + Environment.NewLine + item.Status;
                btn.Click += btn_ShowBill;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Lime;
                        break;
                    case "Đặt trước":
                        btn.BackColor = Color.Yellow;
                        break;
                    default:
                        btn.BackColor = Color.Tomato;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void btn_ShowBill(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).ID;
            dgvShowBill.Tag = tableID;
            btnDiscount.Enabled = true;
            ShowBill(tableID);
        }
        void ShowBill(int id)
        {

            var db = new RestaurantDB();

            var ls = from bi in db.Bill_InFo
                     join b in db.Bills on bi.Bill_ID equals b.ID
                     join f in db.Food on bi.FoodID equals f.ID
                     where b.TableID == id && b.Status == 0
                     select new MenuDTO
                     {
                         Bill_InfoID = bi.ID,
                         Name = f.Name,
                         Count = bi.Count,
                         Price = (float)f.Price,
                         TotalPrice = (float)(f.Price * bi.Count)
                     };
            float totalPrice = ls.Sum(bi => bi.Price * bi.Count);

            menuDTOBindingSource.DataSource = ls.ToList();

            CultureInfo culture = new CultureInfo("en-US");
            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        void LoadFoodCategory()
        {

            var db = new RestaurantDB();
            var ls = db.FoodCategory.OrderBy(c => c.ID)
                .Select(c => new FoodCategoryDTO
                {
                    Id = c.ID,
                    FoodType = c.FoodType,
                }).ToList();

            //B2: Đổ dữ liệu lên cmbDanhMuc
            cbbCategory.DataSource = ls;
            cbbCategory.DisplayMember = "FoodType";
        }

        void LoadFoodListByCategoryID(int categoryID)
        {
            var db = new RestaurantDB();
            var ls = db.Food.Where(c => c.CategoryID == categoryID)
                .Select(c => new FoodDTO
                {
                    Id = c.ID,
                    Name = c.Name,
                    IdCategory = c.CategoryID,
                    Price = c.Price,
                }).ToList();

            //B2: Đổ dữ liệu lên cmbDanhMuc


            if (ls.Count == 0) { cbbFood.DataSource = null; }
            else
            {
                cbbFood.DataSource = ls;
                cbbFood.DisplayMember = "Name";
            }

        }

        void LoadTableToCbb()
        {
            var db = new RestaurantDB();
            var ls = db.Table.OrderBy(t => t.ID)
                .Select(t => new TableDTO
                {
                    ID = t.ID,
                    TableNumber = "Bàn " + t.TableNumber,
                    Status = t.status,
                }).ToList();

            //B2: Đổ dữ liệu lên cmbDanhMuc
            cbbTable.DataSource = ls;
            cbbTable.DisplayMember = "TableNumber";
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAccountProfile f = new FormAccountProfile(account);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.ShowDialog();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            FoodCategoryDTO selected = cb.SelectedItem as FoodCategoryDTO;
            var categoryID = selected.Id;

            LoadFoodListByCategoryID(categoryID);

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            //TableDTO table = dgvShowBill.Tag as TableDTO;

            int tableID = (int)dgvShowBill.Tag;

            InsertBill_BillInfo(tableID);

            UpdateStatusTable(tableID);

            ShowBill(tableID);

            LoadTable();

            nmFoodCount.Value = 1;
        }
        void UpdateStatusTable(int tableID)
        {
            var dbContext = new RestaurantDB();
            var table = dbContext.Table.Where(b => b.ID == tableID).FirstOrDefault();
            if (table != null)
            {

                var bill = dbContext.Bills.Where(b => b.TableID == table.ID && b.Status == 0).FirstOrDefault();
                if (bill != null)
                {
                    var count = dbContext.Bill_InFo.Count(bi => bi.Bill_ID == bill.ID);
                    if (count > 0)
                    {
                        table.status = "Có người";
                    }
                    else
                    {
                        table.status = "Trống";

                    }
                    dbContext.SaveChanges();
                }
            }
        }
        void InsertBill_BillInfo(int tableId)
        {
            {
                var db = new RestaurantDB();


                int foodId = (cbbFood.SelectedItem as FoodDTO).Id;

                int count = (int)nmFoodCount.Value;


                var bill = db.Bills.Where(b => b.TableID == tableId && b.Status == 0).FirstOrDefault();


                if (bill == null)
                {
                    //Insert new Bill 
                    var objBill = new Bill
                    {
                        TableID = tableId,
                        DateCheckIn = DateTime.Now,
                        DateCheckOut = null,
                        Status = 0,
                        Username = account.UserName,
                    };
                    db.Bills.Add(objBill);
                    db.SaveChanges();

                    //Insert new BillInfo
                    var objBillInfo = new Bill_InFo
                    {
                        Bill_ID = db.Bills.Max(c => c.ID),
                        FoodID = foodId,
                        Count = count,
                    };
                    db.Bill_InFo.Add(objBillInfo);
                    db.SaveChanges();
                }
                else
                {
                    //Already had bill, we insert new BillInfo


                    //Check BillInfo có trong Bill chưa?
                    var billInfo = db.Bill_InFo.Where(bi => bi.FoodID == foodId && bi.Bill_ID == bill.ID).FirstOrDefault();
                    //Có thì tăng số lượng
                    if (billInfo != null)
                    {
                        billInfo.Count += count;
                        db.SaveChanges();
                    }
                    else
                    {
                        //Chưa thì thêm 
                        var objBillInfo = new Bill_InFo
                        {
                            Bill_ID = db.Bills.Where(t => t.ID == bill.ID).FirstOrDefault().ID,
                            FoodID = foodId,
                            Count = count,
                        };
                        db.Bill_InFo.Add(objBillInfo);
                        db.SaveChanges();
                    }
                }

            }
        }
        void UpdateBill(int tableID)
        {
            var dbContext = new RestaurantDB();

            var bill = dbContext.Bills.Where(b => b.TableID == tableID && b.Status == 0).FirstOrDefault();

            if (bill != null)
            {
                var count = dbContext.Bill_InFo.Count(bi => bi.Bill_ID == bill.ID);
                if (count == 0)
                {
                    dbContext.Remove(bill);
                }
                dbContext.SaveChanges();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selBillInfo = menuDTOBindingSource.Current as MenuDTO;
            if (selBillInfo != null)
            {
                var rs = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.Bill_InFo.Where(t => t.ID == selBillInfo.Bill_InfoID).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Bill_InFo.Remove(obj);
                        db.SaveChanges();
                        ShowBill((int)dgvShowBill.Tag); ;
                    }
                }
                UpdateStatusTable((int)dgvShowBill.Tag);
                UpdateBill((int)dgvShowBill.Tag);
                LoadTable();
            }
        }
        public void UpdateTableAfterCheckOut(int idBill)
        {
            var db = new RestaurantDB();
            var bill = db.Bills.FirstOrDefault(b => b.ID == idBill);

            if (bill != null)
            {
                int idTable = bill.TableID;

                int count = db.Bills.Count(b => b.TableID == idTable && b.Status == 0);

                if (count == 0)
                {
                    var tableFood = db.Table.FirstOrDefault(tf => tf.ID == idTable);

                    if (tableFood != null)
                    {
                        tableFood.status = "Trống";
                        db.SaveChanges();
                    }
                }
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var db = new RestaurantDB();

            int tableId = 0;

            if (dgvShowBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            tableId = (int)dgvShowBill.Tag;
            if (btnDiscount.Enabled == true)
            {
                Discount();
            }

            float TotalPrice = float.Parse(txtTotalPrice.Text.Split('$')[1]);

            TotalPrice = (float)Math.Round(TotalPrice, 2);

            var bill = db.Bills.Where(b => b.TableID == tableId && b.Status == 0).FirstOrDefault();

            if (bill != null)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho Bàn " + tableId, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    var obj = db.Bills.Where(b => b.ID == bill.ID).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Status = 1;
                        obj.Discount = int.Parse(nmDiscount.Text);
                        obj.DateCheckOut = DateTime.Now;
                        obj.TotalPrice = TotalPrice;
                        db.SaveChanges();
                    }

                    UpdateTableAfterCheckOut(bill.ID);
                    ShowBill(tableId);
                    LoadTable();

                    //In Hoa don
                    BillDTO billDTO = new BillDTO()
                    {
                        ID = bill.ID,
                        TableName = bill.TableID.ToString(),
                        Status = bill.Status,
                        DateCheckIn = bill.DateCheckIn,
                        DateCheckOut = bill.DateCheckOut,
                        Discount = bill.Discount,
                        TotalPrice = bill.TotalPrice,
                        UserName = bill.Username,
                    };

                    var f = new FormPrintBill(billDTO);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                nmFoodCount.Value = 1;
                nmDiscount.Value = 0;
            }
            else
            {
                MessageBox.Show("Bàn này không có hóa đơn!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        void Discount()
        {
            int discount = (int)nmDiscount.Value;
            if (discount > 0)
            {
                double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split('.')[0].Split('$')[1]);
                double finalTotalPrice = totalPrice - ((totalPrice * discount) / 100);
                CultureInfo culture = new CultureInfo("en-US");
                txtTotalPrice.Text = finalTotalPrice.ToString("c", culture);
            }
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Discount();
            btnDiscount.Enabled = false;
        }

        private void dgvShowBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new RestaurantDB();


            var selBillInfo = menuDTOBindingSource.Current as MenuDTO;
            if (selBillInfo != null)
            {
                //Đổ lên 2 cmb
                var idFoodCategory = db.Food.Where(f => f.Name == selBillInfo.Name).FirstOrDefault().CategoryID;


                cbbCategory.Text = db.FoodCategory.Where(fc => fc.ID == idFoodCategory).FirstOrDefault().FoodType;
                cbbFood.Text = selBillInfo.Name;
                nmFoodCount.Value = selBillInfo.Count;
            }
        }
        public void SwitchTable(int idTable1, int idTable2)
        {
            var db = new RestaurantDB();

            // Find the first bill for the first table
            var firstBill = db.Bills.FirstOrDefault(b => b.TableID == idTable1 && b.Status == 0);

            if (firstBill == null)
            {
                // Create a new bill for the first table if it doesn't exist
                firstBill = new Bill
                {
                    DateCheckIn = DateTime.Now,
                    TableID = idTable1,
                    Status = 0,
                    Discount = 0,
                    DateCheckOut = null,
                    TotalPrice = 0,
                    Username = account.UserName
                };

                db.Bills.Add(firstBill);
                db.SaveChanges();
            }
            // Check if there are any items in the first table's bill
            var isFirstTableEmpty = db.Bill_InFo.Count(bi => bi.Bill_ID == firstBill.ID) == 0;

            // Find the second bill for the second table
            var secondBill = db.Bills.FirstOrDefault(b => b.TableID == idTable2 && b.Status == 0);

            if (secondBill == null)
            {
                // Create a new bill for the second table if it doesn't exist
                secondBill = new Bill
                {
                    DateCheckIn = DateTime.Now,
                    TableID = idTable2,
                    Status = 0,
                    Discount = 0,
                    DateCheckOut = null,
                    TotalPrice = 0,
                    Username = account.UserName
                };
                db.Bills.Add(secondBill);
                db.SaveChanges();
            }
            // Check if there are any items in the second table's bill
            var isSecondTableEmpty = db.Bill_InFo.Count(bi => bi.Bill_ID == secondBill.ID) == 0;

            // Swap the items between the two bills
            var firstBillInfoIds = db.Bill_InFo.Where(bi => bi.Bill_ID == firstBill.ID).Select(bi => bi.ID).ToList();

            var secondBillInfoIds = db.Bill_InFo.Where(bi => bi.Bill_ID == secondBill.ID).Select(bi => bi.ID).ToList();

            foreach (var id in firstBillInfoIds)
            {
                db.Bill_InFo.Find(id).Bill_ID = secondBill.ID;
            }

            foreach (var id in secondBillInfoIds)
            {
                db.Bill_InFo.Find(id).Bill_ID = firstBill.ID;
            }
            db.SaveChanges();

            // Update the table status if there are no items in the bills
            if (isFirstTableEmpty)
            {
                var table = db.Table.Where(t => t.ID == idTable2).FirstOrDefault();
                if (table != null)
                {
                    table.status = "Trống";
                }
            }
            if (isSecondTableEmpty)
            {
                var table = db.Table.Where(t => t.ID == idTable1).FirstOrDefault();
                if (table != null)
                {
                    table.status = "Trống";
                }
            }
            db.SaveChanges();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int tableID1 = (int)dgvShowBill.Tag;

            int tableID2 = (cbbTable.SelectedItem as TableDTO).ID;

            if (tableID1 == null || tableID2 == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển bàn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            /*MessageBox.Show(tableID1.ToString(), "Thông báo");*/

            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", tableID1, tableID2), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                SwitchTable(tableID1, tableID2);
                UpdateStatusTable(tableID2);
                UpdateBill(tableID1);
                LoadTable();
            }

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            int tableID = (int)dgvShowBill.Tag;
            if (tableID != null)
            {

                var rs = MessageBox.Show("Bạn có muốn đặt bàn số " + tableID, "Thông báo", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.Table.Where(t => t.ID == tableID).FirstOrDefault();
                    if (obj != null && obj.status == "Trống")
                    {
                        obj.status = "Đặt trước";
                        db.SaveChanges();
                        MessageBox.Show("Đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("bàn số " + tableID + " hiện đang có người", "Thông báo", MessageBoxButtons.OKCancel);
                    }
                }
                LoadTable();
            }

        }

        private void làmMớiBảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTable();
            LoadFoodCategory();
            LoadTableToCbb();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            int tableID = (int)dgvShowBill.Tag;
            if (tableID != null)
            {
                var rs = MessageBox.Show("Bạn muốn hủy đặt bàn số " + tableID, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new RestaurantDB();
                    var obj = db.Table.Where(t => t.ID == tableID).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.status = "Trống";
                        db.SaveChanges();
                        MessageBox.Show("Hủy đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                LoadTable();
            }
        }
    }
}


