using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        double Az;
        double distance;
        double angle;
        double angle2;

        public void Calculate()
        {
            double HtA = 0;
            double HtE = 0;
            double A_az = 0;
            double E_az = 0;
            double H = 0;

            try
            { 
                HtA = double.Parse(HtATextBox.Text);
                HtE = double.Parse(HtETextBox.Text);
                A_az = double.Parse(A_azTextBox.Text);
                E_az = double.Parse(E_azTextBox.Text);
                H = double.Parse(HeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Введено неверное значение.", "Ошибка!", MessageBoxButtons.OK);
            }

            double HtA_cathet = Math.Sqrt(Math.Pow(HtA, 2) + Math.Pow(H, 2));
            double HtE_cathet = Math.Sqrt(Math.Pow(HtE, 2) + Math.Pow(H, 2));


            if (A_az > E_az)
            {
                angle = Math.Abs(A_az - E_az);
                if (Math.Abs(A_az - E_az) > 180)
                {
                    angle = 360 - Math.Abs(A_az - E_az);
                }
                else
                {
                    angle = Math.Abs(A_az - E_az);
                }
            }
            else
            {
                angle = Math.Abs(E_az - A_az);
                if (Math.Abs(E_az - A_az) > 180)
                {
                    angle = 360 - Math.Abs(E_az - A_az);
                }
                else
                {
                    angle = Math.Abs(E_az - A_az);
                }
            }

            distance = Math.Sqrt(Math.Pow(HtA_cathet, 2) + Math.Pow(HtE_cathet, 2) - 2 * HtA_cathet * HtE_cathet * Math.Cos(DegreeToRadian(angle)));
            angle2 = RadianToDegree(Math.Acos((Math.Pow(HtA_cathet, 2) + Math.Pow(distance, 2) - Math.Pow(HtE_cathet, 2)) / (2 * distance * HtA_cathet)));
            double H_az = A_az + 180;
            if (H_az > 360)
            {
                H_az -= 360;
            }

            if ((A_az > E_az && E_az > H_az) | (E_az > H_az && H_az > A_az) | (H_az > A_az && A_az > E_az))
            {
                Az = H_az + angle2;
            }
            else
            {
                Az = H_az - angle2;
            }

            if (Az > 360)
            {
                Az -= 360;
            }
            if (Az < 0)
            {
                Az += 360;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
            distance = Math.Round(distance);
            Az = Math.Round(Az, 1);

            DistanceLabel.Text = (distance.ToString());
            AzimuthLabel.Text = (Az.ToString());
        }
    }
}
