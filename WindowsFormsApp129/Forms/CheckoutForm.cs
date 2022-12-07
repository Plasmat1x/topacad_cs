using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp129.Forms
{
    public partial class CheckoutForm : Form
    {
        List<Customer> waitOrderCustomers = new List<Customer>();
        public CheckoutForm()
        {
            InitializeComponent();
            customerQueue_Timer.Start();
        }

        private void cutomerQueue_Timer_Tick(object sender, EventArgs e)
        {
            if (customers_ListBox.Items.Count > 14) return;

            customers_ListBox.Items.Add(new Customer()); 
        }

        private void customers_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customers_ListBox.SelectedIndex == -1) return;
            detailOrder_Label.Text = "";

            foreach (var item in ((Customer)customers_ListBox.SelectedItem).Order)
            {
                detailOrder_Label.Text += item + Environment.NewLine;
            }
           
        }

        private void cookingTimer_Tick(object sender, EventArgs e)
        {
        }

        private void UpdateCustomerStatus(object sender, int e)
        {
            for (int i = 0; i < waitOrderCustomers.Count; i++)
            {
                cookingDish_ListBox.Items[i] = waitOrderCustomers[i] + " Time: " + waitOrderCustomers[i].CookingTime;
                if (waitOrderCustomers[i].CookingTime <= 0)
                {
                    waitOrderCustomers[i].StopCooking();
                    waitOrderCustomers.RemoveAt(i);
                    cookingDish_ListBox.Items.RemoveAt(i);

                    UpdateLabelWaitOrder();
                }
            }
            //int Id = e;
            //var customer = (Customer)sender;
            //cookingDish_ListBox.Items[index] = customer + " Time: " + customer.CookingTime;
            //if (waitOrderCustomers[index].CookingTime <= 0)
            //{
            //    waitOrderCustomers[index].StopCooking();
            //    waitOrderCustomers.RemoveAt(index);
            //    cookingDish_ListBox.Items.RemoveAt(index);

            //    UpdateLabelWaitOrder();
            //}
        }

        private void acceptOrder_Button_Click(object sender, EventArgs e)
        {
            if (customers_ListBox.SelectedIndex == -1) return;

            waitOrderCustomers.Add((Customer)customers_ListBox.SelectedItem);

            waitOrderCustomers.Last().UpdateInfo += UpdateCustomerStatus;

            waitOrderCustomers.Last().StartCooking();
            cookingDish_ListBox.Items.Add(waitOrderCustomers.Last().Id + ". Order" + " Timer:" + waitOrderCustomers.Last().CookingTime);
            customers_ListBox.Items.Remove(waitOrderCustomers.Last());
            UpdateLabelWaitOrder();
        }
        private void UpdateLabelWaitOrder()
        {
            waitCustomers_Label.Text = "";
            foreach (var item in waitOrderCustomers)
            {
                waitCustomers_Label.Text += item + Environment.NewLine;
            }
        }
    }
}
