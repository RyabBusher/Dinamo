using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamo
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }
        void ShowPersonal()
        {
            listViewPersonal.Items.Clear();
            foreach (PersonalSet personalSet in Program.dinamoDB.PersonalSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    personalSet.ID.ToString(),personalSet.PersonalName,personalSet.PersonalPhone, personalSet.PersonalEmail
                });
                item.Tag = personalSet;
                listViewPersonal.Items.Add(item);
            }
            listViewPersonal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PersonalSet personalSet = new PersonalSet();
            personalSet.PersonalName = textBoxName.Text;
            personalSet.PersonalPhone = textBoxPhone.Text;
            personalSet.PersonalEmail = textBoxEmail.Text;
            Program.dinamoDB.PersonalSet.Add(personalSet);
            Program.dinamoDB.SaveChanges();
            ShowPersonal();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPersonal.SelectedItems.Count == 1)
            {
                PersonalSet personalSet = listViewPersonal.SelectedItems[0].Tag as PersonalSet;
                personalSet.PersonalName = textBoxName.Text;
                personalSet.PersonalPhone = textBoxPhone.Text;
                personalSet.PersonalEmail = textBoxEmail.Text;
                Program.dinamoDB.SaveChanges();
                ShowPersonal();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPersonal.SelectedItems.Count == 1)
                {
                    PersonalSet personalSet = listViewPersonal.SelectedItems[0].Tag as PersonalSet;
                    Program.dinamoDB.PersonalSet.Remove(personalSet);
                    Program.dinamoDB.SaveChanges();
                    ShowPersonal();
                }
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
