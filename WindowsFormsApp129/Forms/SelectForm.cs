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
        User user;
        CheckoutForm checkoutForm;
        public SelectForm(User user)
        {
            InitializeComponent();
            this.user = user;
            switch (user.Role)
            {
                case UserRole.Admin:
                    break;
                case UserRole.Manager:
                    admin_Button.Enabled = false;
                    break;
                case UserRole.Teller:
                    manager_Button.Enabled = false;
                    admin_Button.Enabled = false;
                    break;
            }
            
        }

        private void admin_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Visible = true;
        }

        private void checkout_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
            this.Visible = true;
        }
        ManagerForm managerForm;
        private void manager_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            managerForm = new ManagerForm();
            managerForm.ShowDialog();
            this.Visible = true;
        }
    }
}
