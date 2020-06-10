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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach(ClientSet clientSet in Program.dinamoDB.ClientSet)
            {
                ListViewItem item= new ListViewItem(new string[]
                {
                    clientSet.ID.ToString(), clientSet.ClientName,clientSet.ClientAdress,clientSet.ClientPhone, clientSet.ClientEmail,clientSet.ClientRequisits
                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientSet clientSet = new ClientSet();
            clientSet.ClientName = textBoxName.Text;
            clientSet.ClientAdress = textBoxAdress.Text;
            clientSet.ClientPhone = textBoxPhone.Text;
            clientSet.ClientEmail = textBoxEmail.Text;
            clientSet.ClientRequisits = textBoxRequisits.Text;
            Program.dinamoDB.ClientSet.Add(clientSet);
            Program.dinamoDB.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewClient.SelectedItems.Count==1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.ClientName = textBoxName.Text;
                clientSet.ClientAdress = textBoxAdress.Text;
                clientSet.ClientPhone = textBoxPhone.Text;
                clientSet.ClientEmail = textBoxEmail.Text;
                clientSet.ClientRequisits = textBoxRequisits.Text;
                Program.dinamoDB.SaveChanges();
                ShowClient();
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.ClientName = textBoxName.Text;
                clientSet.ClientAdress = textBoxAdress.Text;
                clientSet.ClientPhone = textBoxPhone.Text;
                clientSet.ClientEmail = textBoxEmail.Text;
                clientSet.ClientRequisits = textBoxRequisits.Text;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxRequisits.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.dinamoDB.ClientSet.Remove(clientSet);                    Program.dinamoDB.SaveChanges();
                    ShowClient();
                }
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxRequisits.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
