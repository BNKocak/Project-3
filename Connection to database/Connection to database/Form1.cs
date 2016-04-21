using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_to_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Cap_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // here we select which picture is needed to be displayed
        {
            int selectedindex = Cap.SelectedIndex; 
            if (selectedindex == 0)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (selectedindex == 1)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (selectedindex == 2)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            if (selectedindex == 3)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
        }
        private void CloseMap_Click(object sender, EventArgs e) { if (CloseMap.Visible == true) { this.Close();} } // this close the map
    }
}