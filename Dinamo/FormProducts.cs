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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }
        void ShowProduct()
        {
            listViewProducts.Items.Clear();
            foreach (ProductSet productSet in Program.dinamoDB.ProductSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    productSet.ID.ToString(), productSet.ProductName, productSet.ProductPrice.ToString(),productSet.Unit.ToString(), productSet.Remains.ToString()
                });
                item.Tag = productSet;
                listViewProducts.Items.Add(item);
            }
            listViewProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProducts.SelectedItems[0].Tag as ProductSet;
                productSet.ProductName = textBoxName.Text;
                productSet.ProductPrice = Convert.ToInt32(textBoxPrice.Text);
                productSet.Unit = textBoxUnit.Text;
                productSet.Remains = Convert.ToInt32(textBoxRemains.Text);
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxUnit.Text = "";
                textBoxRemains.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductSet productSet = new ProductSet();
            productSet.ProductName = textBoxName.Text;
            productSet.ProductPrice = Convert.ToInt32(textBoxPrice.Text);
            productSet.Unit = textBoxUnit.Text;
            productSet.Remains = Convert.ToInt32(textBoxRemains.Text);
            productSet.IDSupplier = Convert.ToInt32(comboBoxSupplier.SelectedItem.ToString().Split('.')[0]);
            Program.dinamoDB.ProductSet.Add(productSet);
            Program.dinamoDB.SaveChanges();
            ShowProduct();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProducts.SelectedItems[0].Tag as ProductSet;
                productSet.ProductName = textBoxName.Text;
                productSet.ProductPrice = Convert.ToInt32(textBoxPrice.Text);
                productSet.Unit = textBoxUnit.Text;
                productSet.Remains = Convert.ToInt32(textBoxRemains.Text);
                productSet.IDSupplier = Convert.ToInt32(comboBoxSupplier.SelectedItem.ToString().Split('.')[0]);
                Program.dinamoDB.SaveChanges();
                ShowProduct();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProducts.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewProducts.SelectedItems[0].Tag as ProductSet;
                    Program.dinamoDB.ProductSet.Remove(productSet);
                    Program.dinamoDB.SaveChanges();
                    ShowProduct();
                }
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxUnit.Text = "";
                textBoxRemains.Text = "";
                comboBoxSupplier.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
