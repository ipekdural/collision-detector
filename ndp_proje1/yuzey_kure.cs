﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ndp_proje1
{
    public partial class yuzey_kure : Form
    {
        int control = 0;
        Sphere sphere1 = new Sphere();
        Surface surface1 = new Surface();
        public yuzey_kure()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        public void yuzeyKure()
        {
            sphere1.x = (int)numericUpDown1.Value;
            sphere1.y = (int)numericUpDown2.Value;
            sphere1.z = (int)numericUpDown3.Value;
            sphere1.radius = (int)numericUpDown4.Value;

            surface1.x = (int)numericUpDown5.Value;
            surface1.y = (int)numericUpDown6.Value;
            surface1.z = (int)numericUpDown7.Value;
            surface1.nx = (int)numericUpDown8.Value;
            surface1.ny = (int)numericUpDown9.Value;
            surface1.nz = (int)numericUpDown10.Value;

            float distance = (float)((sphere1.x - surface1.x) * surface1.nx) + ((sphere1.y - surface1.y) * surface1.ny) + ((sphere1.z - surface1.z) * surface1.nz);
            if (distance <= 0)
            {
                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {
                MessageBox.Show("Collision has not occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        class Sphere
        {
            public int x;
            public int y;
            public int z;
            public int radius;

        }
        class Surface
        {
            public int x;
            public int y;
            public int z;
            public int nx;
            public int ny;
            public int nz;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yuzeyKure();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_surface_sphere draw_Surface_Sphere = new draw_surface_sphere();
            draw_Surface_Sphere.x = control;
            draw_Surface_Sphere.Show();
            this.Hide();
        }
    }

}
