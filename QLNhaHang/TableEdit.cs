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
    public partial class TableEdit : Form
    {
        TableDTO tableFood;
        List<string> lstStatus = new List<string>();
        public TableEdit(TableDTO tableFood = null)
        {
            InitializeComponent();
            this.tableFood = tableFood;

            //Đưa đồ cũ lên nếu cập nhật
            lstStatus.Add("Trống");

            if (tableFood != null)
            {
                this.Text = "Cập nhật bàn";
                lblTitle.Text = "Cập nhật bàn";
                txtTableID.Text = tableFood.ID.ToString();
                txtTableName.Text = tableFood.TableNumber;
                lstStatus.Add("Đặt trước");
                lstStatus.Add("Có người");
            }
            cmbTableStatus.DataSource = lstStatus;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var selTable = cmbTableStatus.SelectedItem;
            var db = new RestaurantDB();
            if (tableFood == null)
            {
                //Thêm mới
                var obj = new Table
                {
                    TableNumber = txtTableName.Text,
                    status = "Trống",
                };
                db.Table.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Cập nhật
                var obj = db.Table.Where(t => t.ID == tableFood.ID).FirstOrDefault();
                obj.TableNumber = txtTableName.Text;
                DialogResult = DialogResult.OK;
                if (DialogResult == DialogResult.OK)
                {
                    var check = db.Bills.Where(b => b.TableID == tableFood.ID && b.Status == 0).FirstOrDefault();
                    if (check != null && (cmbTableStatus.Text == "Trống" || cmbTableStatus.Text == "Đặt trước"))
                    {
                        MessageBox.Show("Bàn này hiện có hóa đơn cần thanh toán để sửa trạng thái!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        obj.status = (string)selTable;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
