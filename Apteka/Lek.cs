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
    public partial class Lek : Form
    {
        public Lek()
        {
            InitializeComponent();
            ShowItem();
        }

        void ShowItem()
        {
            listViewLek.Items.Clear();
            foreach (Lekarstvo lekarstvo in Program.apteka.Lekarstvo)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    lekarstvo.Name, lekarstvo.Forma,
                    lekarstvo.Doza, lekarstvo.Proiz, lekarstvo.Srok
                });
                item.Tag = lekarstvo;
                listViewLek.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || comboBoxForma.Text == "" || textBoxDoza.Text == "" || textBoxProiz.Text == "" || textBoxSrok.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Lekarstvo lekarstvo = new Lekarstvo();
                lekarstvo.Name = textBoxName.Text;
                lekarstvo.Forma = comboBoxForma.SelectedItem.ToString().Split('.')[0];
                lekarstvo.Doza = textBoxDoza.Text;
                lekarstvo.Proiz = textBoxProiz.Text;
                lekarstvo.Srok = textBoxSrok.Text;
                Program.apteka.Lekarstvo.Add(lekarstvo);
                Program.apteka.SaveChanges();
                Lek lek = new Lek();
                lek.Show();
                this.Hide();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            {
                if (listViewLek.SelectedItems.Count == 1)
                {
                    Lekarstvo lekarstvo = listViewLek.SelectedItems[0].Tag as Lekarstvo;
                    lekarstvo.Name = textBoxName.Text;
                    lekarstvo.Forma = comboBoxForma.SelectedItem.ToString().Split('.')[0];
                    lekarstvo.Doza = textBoxDoza.Text;
                    lekarstvo.Proiz = textBoxProiz.Text;
                    lekarstvo.Srok = textBoxSrok.Text;
                    Program.apteka.SaveChanges();
                    Lek lek = new Lek();
                    lek.Show();
                    this.Hide();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewLek.SelectedItems.Count == 1)
                {
                    Lekarstvo lekarstvo = listViewLek.SelectedItems[0].Tag as Lekarstvo;
                    Program.apteka.Lekarstvo.Remove(lekarstvo);
                    Program.apteka.SaveChanges();
                    Lek lek = new Lek();
                    lek.Show();
                    this.Hide();
                }
                textBoxName.Text = "";
                comboBoxForma.SelectedItem = null;
                textBoxDoza.Text = "";
                textBoxProiz.Text = "";
                textBoxSrok.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewLek_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listViewLek.SelectedItems.Count == 1)
                {
                    Lekarstvo lekarstvo = listViewLek.SelectedItems[0].Tag as Lekarstvo;
                    textBoxName.Text = lekarstvo.Name;
                    comboBoxForma.SelectedItem = lekarstvo.Forma;
                    textBoxDoza.Text = lekarstvo.Doza;
                    textBoxProiz.Text = lekarstvo.Proiz;
                    textBoxSrok.Text = lekarstvo.Srok;
                }
                else
                {
                    textBoxName.Text = "";
                    comboBoxForma.SelectedItem = null;
                    textBoxDoza.Text = "";
                    textBoxProiz.Text = "";
                    textBoxSrok.Text = "";
                }
            }
        }
    }
}
