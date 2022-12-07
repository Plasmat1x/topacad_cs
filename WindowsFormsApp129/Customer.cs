using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129
{
    public class Customer
    {

        public event EventHandler<int> UpdateInfo;

        private static int counter;
        public int Id { get; set; }
        private DishData dishData = new DishData();
        public List<Dish> Order { get; set; } = new List<Dish>();
        private Timer cookingTimer;
        public double CookingTime;

        Random rnd;
        public Customer()
        {

            counter++;
            cookingTimer = new Timer();
            cookingTimer.Interval = 1000;

            Id = counter;
            rnd = new Random();
            LoadDishes();
            Order.Add(dishData.AllDishes[rnd.Next(0, dishData.AllDishes.Count)]);
            Order.Add(dishData.AllDishes[rnd.Next(0, dishData.AllDishes.Count)]);

            CookingTime = Order[0].CookingTime + Order[1].CookingTime;

            cookingTimer.Tick += CookingTimer_Tick;
        }

        private void CookingTimer_Tick(object sender, EventArgs e)
        {
            CookingTime -= 10;
            UpdateInfo(this, Id);

        }

        public void StartCooking()
        {
            cookingTimer.Start();
        }
        public void StopCooking()
        {
            cookingTimer.Stop();
        }
        private void LoadDishes()
        {
            dishData = (DishData)SerializeService.ObjDeserialize(dishData, typeof(DishData), new XmlSerializeCustom());
        }
        public override string ToString()
        {
            return $"{Id}. Customer";
        }
    }
}
