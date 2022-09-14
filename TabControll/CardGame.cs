using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControll
{
    internal class CardGame
    {
        private int card1 = -1;
        private int card2 = -1;
        public int[] indexArray;
        public int index1 = -1;
        public int index2 = -1;
        private int points = 0;

        Random rand;

        public CardGame()
        {
            rand = new Random();

            indexArray = new int[6];

            for (int i = 0; i < 6; i++)
            {
                indexArray[i] = i;
            }

            for (int i = 0; i < 6; i++)
            {
                int x = rand.Next(0, indexArray.Length);

                int temp = indexArray[i];
                indexArray[i] = indexArray[x];
                indexArray[x] = temp;
            }

            points = 500;
        }

        public void next(int index)
        {
            if (card1 == -1)
            {
                card1 = indexArray[index];
                index1 = index;
            }
            else
            {
                card2 = indexArray[index];
                index2 = index;
            }
        }

        public bool check()
        {
            if (card1 == card2 && card1 != -1)
            {
                points += 100;
                card1 = -1;
                card2 = -1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
