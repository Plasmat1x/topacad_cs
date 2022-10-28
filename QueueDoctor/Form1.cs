using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueDoctor
{
    public partial class Form1 : Form
    {
        Queue<Human> therapist; 
        Queue<Human> neurologist;
        Queue<Human> surgeon;

        public Form1()
        {
            InitializeComponent();

            therapist = new Queue<Human>();
            neurologist = new Queue<Human>();
            surgeon = new Queue<Human>();

            label1.Text = "Name";
            label2.Text = "Phone";
            label3.Text = "Doctor";
            label4.Text = DoctorType.threapist.ToString();
            label5.Text = DoctorType.neurologist.ToString();
            label6.Text = DoctorType.surgeon.ToString();

            comboBox1.Items.Add(DoctorType.threapist.ToString());
            comboBox1.Items.Add(DoctorType.neurologist.ToString());
            comboBox1.Items.Add(DoctorType.surgeon.ToString());
            comboBox1.TabIndex = 0;

            button1.Text = "Get in line";

            update();
        }

        private void update()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            foreach (var item in therapist)
            {
                listBox1.Items.Add(item.Name + " " +item.Phone);
            }

            foreach (var item in neurologist)
            {
                listBox2.Items.Add(item.Name + " " + item.Phone);
            }

            foreach (var item in surgeon)
            {
                listBox3.Items.Add(item.Name + " " + item.Phone);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool available = true;

            switch ((DoctorType)comboBox1.SelectedIndex)
            {
                case DoctorType.neurologist:
                    {
                        foreach (var item in neurologist)
                        {
                            if (item.Phone == textBox2.Text)
                            {
                                available = false;
                                break;
                            }
                            else
                            {
                                available = true;
                            }
                        }

                        if (available)
                            neurologist.Enqueue(new Human(textBox1.Text, textBox2.Text, (DoctorType)comboBox1.SelectedIndex));
                    }
                    break;
                    
                case DoctorType.surgeon:
                    {
                        foreach (var item in surgeon)
                        {
                            if (item.Phone == textBox2.Text)
                            {
                                available = false;
                                break;
                            }
                            else
                            {
                                available = true;
                            }
                        }

                        if (available)
                            surgeon.Enqueue(new Human(textBox1.Text, textBox2.Text, (DoctorType)comboBox1.SelectedIndex));
                    }
                    break;

                case DoctorType.threapist:
                    {
                        foreach (var item in therapist)
                        {
                            if (item.Phone == textBox2.Text)
                            {
                                available = false;
                                break;
                            }
                            else
                            {
                                available = true;
                            }
                        }

                        if (available)
                            therapist.Enqueue(new Human(textBox1.Text, textBox2.Text, (DoctorType)comboBox1.SelectedIndex));
                    }
                    break;
            }

            textBox1.Text = "";
            textBox2.Text = "";
            update();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(therapist.Count > 0)
            {
                therapist.Dequeue();
                update();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (neurologist.Count > 0)
            {
                neurologist.Dequeue();
                update();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (surgeon.Count > 0)
            {
                surgeon.Dequeue();
                update();
            }
        }
    }
}
