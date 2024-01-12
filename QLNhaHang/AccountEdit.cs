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
    public partial class AccountEdit : Form
    {
        AccountDTO account;
        List<string> lstType = new List<string>();
        public AccountEdit(AccountDTO account = null)
        {
            InitializeComponent();
            this.account = account;
            lstType.Add("Admin");
            lstType.Add("Employee");
            cmbType.DataSource = lstType;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var selAccount = cmbType.SelectedItem;
            var db = new RestaurantDB();
            if (account == null)
            {
                //Thêm mới
                var obj = new Account
                {
                    UserName = txtUsername.Text,
                    DisplayName = txtDisplayName.Text,
                    Password = "123",
                    Type = selAccount.Equals("Admin") ? 1 : 0,
                };
                db.Account.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
