using QLNhaHang.DTO;
using QLNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang
{
    public partial class FormAccountProfile : Form
    {
        AccountDTO account;
        public FormAccountProfile(AccountDTO account)
        {
            InitializeComponent();
            this.account = account;
            txtun.Text = account.UserName;
            txtName.Text = account.DisplayName;
        }
        void UpdateAccountInfo()
        {
            string displayName = txtName.Text;
            string password = txtPass.Text;
            string userName = txtun.Text;
            UpdateDisplayName(userName, displayName, password, account);
        }
        public void UpdateDisplayName(string userName, string displayName, string password, AccountDTO account)
        {
            var db = new RestaurantDB();
            var isRightPass = db.Account
                .Where(a => a.UserName == userName && a.Password == password)
                .Count();

            if (isRightPass == 1)
            {
                var accountToUpdate = db.Account.Where(a => a.UserName == userName).FirstOrDefault();
                accountToUpdate.DisplayName = displayName;
                account.DisplayName = displayName;
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mật khấu", "Thông báo");
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
            txtPass.Text = "";
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePass f = new FormChangePass(account);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Lấy tất cả form đang mở
                FormCollection openForms = Application.OpenForms;

                // Duyệt qua tất cả form
                foreach (Form form in openForms)
                {
                    if (form.Name == "FormLogin")
                    {
                        continue;
                    }
                    // Đóng form
                    form.Close();
                }
            }
        }
    }
}
