using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsDemo
{
    internal class Car
    {
        //private fields
        private PictureBox myPic = new PictureBox();
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        //public properties


        //constructor
        public Car(Form mainForm,int x, int y)
        {
            myPic.Image = new Bitmap("car1.png");   //Add error checking
            myPic.SizeMode = PictureBoxSizeMode.AutoSize;
            myPic.BackColor = Color.Transparent;
            myPic.Left = x;
            myPic.Top = y;
            mainForm.Controls.Add(myPic);

            myTimer.Interval = 100;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Enabled = true;




        }

        private void MyTimer_Tick(object? sender, EventArgs e)
        {

            myPic.Left += 5;

        }
    }
}
