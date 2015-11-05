/*
 * Created by:  Perry Martin
 * Created on: 05-11-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-05
 * This program the volume of a cylinder
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumeOfACylinder
{
    public partial class frmVolume : Form
    {
        public double CalculateVolume(double radius, double height)
        {
            // Variable

            double volume = 0;

            volume = Math.PI * Math.Pow(radius, 2) * height;

            return volume;
        }

        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            double radius;
            double height;
            double volume;

            // Input
            radius = Convert.ToDouble(this.txtRadius.Text);
            height = Convert.ToDouble(this.txtHeight.Text);

            // process

            volume = CalculateVolume(radius, height);
            volume = Math.Round(volume, 2);

            
            // output

            this.lblAnswer.Text = Convert.ToString(volume);
        
         }
    }
}
