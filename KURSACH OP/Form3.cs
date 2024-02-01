using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KURSACH_OP
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegYes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RegLogin.Text) && !string.IsNullOrEmpty(RegPass.Text) && !string.IsNullOrEmpty(RegPass2.Text))
            {
                if (RegPass.Text == RegPass2.Text)
                {
                    Database db = new Database("Data Source=baza.db;Version=3;");
                    string login = RegLogin.Text;
                    string password = Hash(RegPass.Text); // Хэшируем введенный пароль

                    if (db.AddUser(login, password))
                    {
                        // Пользователь успешно добавлен
                        FormAuth formAuth = new FormAuth();
                        formAuth.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Ошибка при добавлении пользователя
                        MessageBox.Show("Ошибка при добавлении пользователя в базу данных");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxPass12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass12.Checked)
            {
                RegPass.PasswordChar = '\0'; // Отображаем текст вместо *
                RegPass2.PasswordChar = '\0';
            }
            else
            {
                RegPass.PasswordChar = '*'; // Возвращаем обратно *
                RegPass2.PasswordChar = '*';
            }
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

        private void FormReg_Load(object sender, EventArgs e)
        {

        }
    }
}
