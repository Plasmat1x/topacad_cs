using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129
{
    public partial class AddDishForm : Form
    {
        DishData dishData;

        List<string> ingredients = new List<string>();

        public AddDishForm(DishData dishData)
        {
            InitializeComponent();
            this.dishData = dishData;
        }

        private void addDish_Button_Click(object sender, EventArgs e)
        {
            dishData.AddNewDish(new Dish(dishName_TextBox.Text, (double)cookingTime_NumericUpDown.Value, ingredients));
            this.DialogResult = DialogResult.OK;
        }

        private void addIngredient_Button_Click(object sender, EventArgs e)
        {

            string ingredientName = ingredients_ComboBox.Text;
            if (string.IsNullOrWhiteSpace(ingredientName) == true) return;

            if (ingredients.Contains(ingredientName) == false)
            {
                ingredients_ComboBox.Items.Add(ingredientName);
            }
            ingredients_ListBox.Items.Add(ingredientName);
            ingredients.Add(ingredientName);
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            ingredients = (List<string>)SerializeService.ObjDeserialize(ingredients.GetType(), "ingredients");
            if (ingredients == null) ingredients = new List<string>();

            foreach (var item in ingredients)
            {
                ingredients_ComboBox.Items.Add(item);
            }
        }

        private void AddDishForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeService.ObjSerialize(ingredients, ingredients.GetType(), "ingredients");
        }
    }
}
