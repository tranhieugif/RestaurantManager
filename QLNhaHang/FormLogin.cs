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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtun.Text;
            String password = txtpass.Text;

            var db = new RestaurantDB();
            var user = db.Account.Where(c => c.UserName == username && c.Password == password)
                .Select(c => new AccountDTO
                {
                    UserName = c.UserName,
                    DisplayName = c.DisplayName,
                    PassWord = c.Password,
                    Type = c.Type,
                })
                .SingleOrDefault();

            if (user != null)
            {
                FormManageTable f = new FormManageTable(user);
                txtun.Text = "";
                txtpass.Text = "";
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
    }
}
