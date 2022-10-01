using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeCast
{
    internal class Cube : PictureBox
    {
        private int[] stat;
        private Random random;
        private ImageList imageList;
        private const int size = 6;

        public Cube()
        {
            stat = new int[size];
            base.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void AddImage(ImageList il)
        {
            this.imageList = il;
        }

        public void Cast()
        {
            int index = new Random().Next(0,size);
            base.Image = imageList.Images[index];
            stat[index]++;
        }

        public string Statistic()
        {
            string res = "";

            for(int i = 0; i < stat.Length; i++)
            {
                res += $"Edge {i + 1}:  {stat[i]}" + Environment.NewLine;
            }

            return res;
        }
    }
}
