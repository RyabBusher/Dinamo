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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonClientsOpen_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonProductsOpen_Click(object sender, EventArgs e)
        {
            Form formProducts = new FormProducts();
            formProducts.Show();
        }

        private void buttonSuppliersOpen_Click(object sender, EventArgs e)
        {
            Form formSupplier = new FormSupplier();
            formSupplier.Show();
        }

        private void buttonPersonalOpen_Click(object sender, EventArgs e)
        {
            Form formPersonal = new FormPersonal();
            formPersonal.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
