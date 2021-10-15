using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(button1.Text);
            animals.Add(new Shuka());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(button2.Text);
            animals.Add(new Golub());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(button4.Text);
            animals.Add(new Medved());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(button5.Text);
            animals.Add(new Crocodile());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(button3.Text);
            animals.Add(new Shlepa());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = animals[index].WhatICan();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;



            if (animals[index] is IRun)
            {
                button8.Visible = true;
            }
            else
            {
                button8.Visible = false;
            }
            if (animals[index] is ISwim)
            {
                button9.Visible = true;
            }
            else
            {
                button9.Visible = false;
            }
            if (animals[index] is IFly)
            {
                button10.Visible = true;
            }
            else
            {
                button10.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = animals[index].WhoAmI();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (animals[index] as IRun).Run();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = (animals[index] as IFly).Fly();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (animals[index] as ISwim).Swim();
        }

    }
}
