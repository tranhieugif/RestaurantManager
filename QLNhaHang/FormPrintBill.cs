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
    public partial class FormPrintBill : Form
    {
        public FormPrintBill(BillDTO bill)
        {
            InitializeComponent();
            var db = new RestaurantDB();
            var employee = db.Account.Where(a => a.UserName == bill.UserName).FirstOrDefault();
            lblDateCheckOut.Text += DateTime.Now.ToString();
            lblIDBill.Text += bill.ID.ToString();
            lblStaff.Text += employee.DisplayName;
            lblTable.Text += bill.TableName;
            lblDiscount.Text += bill.Discount.ToString() + "%";
            lblTotalPrice.Text += "$" + bill.TotalPrice.ToString();
            ShowBill(bill.ID);
        }
        void ShowBill(int idBill)
        {
            //lsvBill.Items.Clear();

            var db = new RestaurantDB();

            var listBillInfo = from bi in db.Bill_InFo
                               join b in db.Bills on bi.Bill_ID equals b.ID
                               join f in db.Food on bi.FoodID equals f.ID
                               where b.ID == idBill && b.Status == 1
                               select new MenuDTO
                               {
                                   Bill_InfoID = bi.ID,
                                   Name = f.Name,
                                   Count = bi.Count,
                                   Price = (float)f.Price,
                                   TotalPrice = (float)(f.Price * bi.Count)
                               };

            menuDTOBindingSource.DataSource = listBillInfo.ToList();

        }
    }
}
