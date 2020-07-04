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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text.Length > 0)
            {
                if (textBoxPass.Text.Length > 0)
                {
                    if (textBoxPassCopy.Text.Length > 0)
                    {
                        Users user = new Users();
                        user.FirstName = textBoxFirstName.Text;
                        user.MiddleName = textBoxMiddleName.Text;
                        user.LastName = textBoxLastName.Text;
                        user.Login = textBoxLog.Text;
                        user.Password = textBoxPass.Text;
                        user.Phone = textBoxPhone.Text;
                        user.Email = textBoxEmail.Text;
                        Program.apteka.Users.Add(user);
                        Program.apteka.SaveChanges();
                        try { }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        Close();
                        if (textBoxPass.Text == textBoxPassCopy.Text)
                        {
                            MessageBox.Show("Пользователь зарегистрирован");
                        }
                        else MessageBox.Show("Пароли не совподают");
                    }
                    else MessageBox.Show("Повторите пароль");
                }
                else MessageBox.Show("Укажите пароль");
            }
            else MessageBox.Show("Укажите логин");
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                textBoxEmail.Visible = true;
                textBoxPhone.Visible = true;

                textBoxFirstName1.Visible = false;
                textBoxMiddleName1.Visible = false;
                textBoxLastName1.Visible = false;
                textBoxLog1.Visible = false;
                textBoxPass1.Visible = false;

                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxLog.Text = "";
                textBoxPass.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                textBoxEmail.Visible = false;
                textBoxPhone.Visible = false;
                textBoxFirstName.Visible = false;
                textBoxMiddleName.Visible = false;
                textBoxLastName.Visible = false;
                textBoxLog.Visible = false;
                textBoxPass.Visible = false;
                

                textBoxFirstName1.Visible = true;
                textBoxMiddleName1.Visible = true;
                textBoxLastName1.Visible = true;
                textBoxLog1.Visible = true;
                textBoxPass1.Visible = true;

                textBoxFirstName1.Text = "";
                textBoxMiddleName1.Text = "";
                textBoxLastName1.Text = "";
                textBoxLog1.Text = "";
                textBoxPass1.Text = "";
            }
        }
    }
}
