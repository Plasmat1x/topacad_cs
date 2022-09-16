using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalc
{
    internal class Party
    {

        private int guestNumber;
        private bool specialDesign;
        private bool healthyFood;
        private double summary;
        private double discount = 0.05;

        private void discountCalc()
        {
            summary -= summary * discount;
        }

        public double calc(int guests, bool special, bool healthy)
        {
            guestNumber = guests;
            specialDesign = special;
            healthyFood = healthy;

            summary = 0;
            summary += guestNumber * 25.0;


            if (specialDesign)
            {
                summary += guestNumber * 15.0;
                summary += 50.0;
            }
            else
            {
                summary += guestNumber * 7.50;
                summary += 30.0;
            }

            if (healthyFood)
            {
                summary += guestNumber * 5.0;
                discountCalc();
            }
            else
            {
                summary += guestNumber * 20.0;
            }

            return summary;
        }
    }
    internal class Birthday
    {
        private int guests;
        private bool specialDesign;
        private double summary;
        string word;

        public double calc(int guests, bool special, string word)
        {
            this.guests = guests;
            this.specialDesign = special;
            this.word = word;

            summary = 0;
            summary += guests * 25.0;

            if (special)
            {
                summary += (guests * 15.0) + 50.0;
            }
            else
            {
                summary += (guests * 7.5) + 30.0;
            }

            if (guests < 4)
            {
                summary += 40.0;
            }
            else
            {
                summary += 75.0;
            }

            for (int i = 0; i < word.Length; i++)
            {
                summary += 0.25;
            }

            return summary;
        }
    }
}
