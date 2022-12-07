using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129
{
    public partial class AdminForm : Form
    {
        AddDishForm addDishForm;
        DishData dishData;
       
        public AdminForm()
        {
            InitializeComponent();
            dishData = new DishData();
           
        }

        private void addDish_Button_Click(object sender, EventArgs e)
        {
            addDishForm = new AddDishForm(dishData);
            addDishForm.ShowDialog();

        }

       
        private void AdminForm_Load(object sender, EventArgs e)
        {
            dishData = (DishData)SerializeService.ObjDeserialize(dishData, dishData.GetType(), new XmlSerializeCustom());

            foreach (var item in dishData.AllDishes)
            {
                dishes_ListBox.Items.Add(item);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeService.ObjSerialize(dishData, dishData.GetType(), new XmlSerializeCustom());//typeof(DishData)

        }
    }
}
