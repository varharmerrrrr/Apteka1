using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class Log : Form
    {
        public static Users users = new Users();
        public Log()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.apteka.Users)
                {
                    if (textBoxLog.Text == user.Login && textBoxPass.Text == user.Password)
                    {
                        key = true;
                        users.Login = user.Login;
                        users.Password = user.Password;
                        users.FirstName = user.FirstName;
                        users.LastName = user.LastName;
                        users.MiddleName = user.MiddleName;
                        users.Type = user.Type;
                    }
                }
                foreach (Doktor doktor in Program.apteka.Doktor)
                {
                    if (textBoxLog.Text == doktor.Login && textBoxPass.Text == doktor.Password)
                    {
                        key = true;
                        users.Login = doktor.Login;
                        users.Password = doktor.Password;
                        users.FirstName = doktor.FirstName;
                        users.LastName = doktor.LastName;
                        users.MiddleName = doktor.MiddleName;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLog.Text = "";
                    textBoxPass.Text = "";
                }

                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }
    }
}
