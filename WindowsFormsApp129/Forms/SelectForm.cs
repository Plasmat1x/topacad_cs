using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp129.Forms;

namespace WindowsFormsApp129
{
    public partial class SelectForm : Form
    {
        AdminForm adminForm;
        CheckoutForm checkoutForm;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void admin_Button_Click(object sender, EventArgs e)
        {
            adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void checkout_Button_Click(object sender, EventArgs e)
        {
            checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
        }
    }
}
