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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }
        void ShowSupplier()
        {
            listViewSupplier.Items.Clear();
            foreach (SupplierSet supplierSet in Program.dinamoDB.SupplierSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supplierSet.ID.ToString(), supplierSet.SupplierName,supplierSet.SupplierAdress,supplierSet.SupplierPhone, supplierSet.SupplierEmail,supplierSet.SupplierRequisites
                });
                item.Tag = supplierSet;
                listViewSupplier.Items.Add(item);
            }
            listViewSupplier.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierSet supplierSet = new SupplierSet();
            supplierSet.SupplierName = textBoxName.Text;
            supplierSet.SupplierAdress = textBoxAdress.Text;
            supplierSet.SupplierPhone = textBoxPhone.Text;
            supplierSet.SupplierEmail = textBoxEmail.Text;
            supplierSet.SupplierRequisites = textBoxRequisits.Text;
            Program.dinamoDB.SupplierSet.Add(supplierSet);
            Program.dinamoDB.SaveChanges();
            ShowSupplier();
        }

        private void listViewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count == 1)
            {
                SupplierSet supplierSet = listViewSupplier.SelectedItems[0].Tag as SupplierSet;
                supplierSet.SupplierName = textBoxName.Text;
                supplierSet.SupplierAdress = textBoxAdress.Text;
                supplierSet.SupplierPhone = textBoxPhone.Text;
                supplierSet.SupplierEmail = textBoxEmail.Text;
                supplierSet.SupplierRequisites = textBoxRequisits.Text;
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count == 1)
            {
                SupplierSet supplierSet = listViewSupplier.SelectedItems[0].Tag as SupplierSet;
                supplierSet.SupplierName = textBoxName.Text;
                supplierSet.SupplierAdress = textBoxAdress.Text;
                supplierSet.SupplierPhone = textBoxPhone.Text;
                supplierSet.SupplierEmail = textBoxEmail.Text;
                supplierSet.SupplierRequisites = textBoxRequisits.Text;
                Program.dinamoDB.SaveChanges();
                ShowSupplier();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplier.SelectedItems.Count == 1)
                {
                    SupplierSet supplierSet = listViewSupplier.SelectedItems[0].Tag as SupplierSet;
                    Program.dinamoDB.SupplierSet.Remove(supplierSet); 
                    Program.dinamoDB.SaveChanges();
                    ShowSupplier();
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
