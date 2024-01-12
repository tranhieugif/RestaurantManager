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
using System.Xml.Linq;

namespace QLNhaHang
{
    public partial class FormChangePass : Form
    {
        AccountDTO account;
        public FormChangePass(AccountDTO account)
        {
            InitializeComponent();
            this.account = account;
        }
        void UpdateAccountInfo()
        {
            string userName = account.UserName;
            string newPass = txtNewPass.Text;
            string password = txtPass.Text;
            string confirmPass = txtConfirmPass.Text;
            UpdatePass(newPass, confirmPass, password, userName);
        }
        public void UpdatePass(string newPass, string confirmPass, string password, string userName)
        {
            var db = new RestaurantDB();
            var isRightPass = db.Account
                .Where(a => a.UserName == userName && a.Password == password)
                .Count();

            if (isRightPass == 1)
            {
                if (password.Equals(newPass))
                {
                    MessageBox.Show("Mật khấu cũ trùng với mật khẩu mới", "Thông báo");
                }
                else
                {
                    if (newPass.Equals(confirmPass))
                    {
                        var accountToUpdate = db.Account.Where(a => a.UserName == userName).FirstOrDefault();
                        accountToUpdate.Password = newPass;
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Mật khấu mới không trùng với xác nhận mật khẩu", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mật khấu", "Thông báo");
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();

        }
    }
}
