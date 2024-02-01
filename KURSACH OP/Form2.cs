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

namespace KURSACH_OP
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPass.Text;

            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                password = Hash(password); // Хэшируем введенный пароль
                Database db = new Database("Data Source=baza.db;Version=3;");
                if (db.ValidUser(login, password))
                {
                    this.Hide();
                    FormMain form3 = new FormMain();
                    form3.Closed += (s, args) => this.Close();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var formMain = new FormReg();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                textBoxPass.PasswordChar = '\0'; // Отображаем текст вместо *
            }
            else
            {
                textBoxPass.PasswordChar = '*'; // Возвращаем обратно *
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
