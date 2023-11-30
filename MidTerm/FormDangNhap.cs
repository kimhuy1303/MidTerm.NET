using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class FormDangNhap : Form
    {

        public FormDangNhap()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Cảnh báo");

                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                if (checkLogin(txtUsername.Text, txtPassword.Text))
                {
                    FormChuongTrinh f = new FormChuongTrinh(Const.Authorize);
                    f.Show();
                    this.Hide();
                    f.Logout += F_Logout;
                  
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu", "Lỗi");

                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private void F_Logout(object? sender, EventArgs e)
        {
            // sender Tham chiếu
            (sender as FormChuongTrinh).isClose = false;
            (sender as FormChuongTrinh).Close();
            this.Show();
            this.txtUsername.Focus();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }

        bool checkLogin(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashPassword = "";
            foreach (byte data in hashData)
            {
                hashPassword += data.ToString();
            }
            using (var context = new MainDbContext())
            {
                var res = context.Accounts?.Where(account => account.Username == username && account.Password == hashPassword).FirstOrDefault();
                if (res != null)
                {
                    var role = context.Roles.Where(p => p.Id == res.RoleId).FirstOrDefault();
                    Const.Authorize = role.RoleName;
                }
                return res == null ? false : true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
