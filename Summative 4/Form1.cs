// Addie Pant
// November 25, 2016
// Santa Claus Christmas Delievery thingy
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Summative_4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        { 
          
          //define brushes, integers, sound players and graphics
          Pen chimneyPen = new Pen(Color.Red, 10);
          SolidBrush giftBrush = new SolidBrush(Color.Snow); 
          SolidBrush flameBrush = new SolidBrush(Color.Orange);
          SolidBrush lightBrush = new SolidBrush(Color.IndianRed);
          SolidBrush slayBrush = new SolidBrush(Color.SaddleBrown);
          int x = 422; 
          Graphics fg = this.CreateGraphics();
          SoundPlayer message = new SoundPlayer(Properties.Resources.message);
          SoundPlayer boom = new SoundPlayer(Properties.Resources.boom);

            //when button is pressed change background colour to Black and make outputLabel and startButton invisble
          this.BackColor = Color.Black;
          outputLabel.Visible = false;
          startButton.Visible = false;

          //Mission statement
          Font drawFont = new Font("Arial", 12, FontStyle.Bold);
          SolidBrush drawBrush = new SolidBrush(Color.Red);
          fg.DrawString("Mission Statement: Drop Santas Christmas Present in the chimney when the fire's lit", drawFont, drawBrush, 0, 140);
          message.Play();
          Thread.Sleep(5000);
           
          //sleigh and chimney
          for (int i = 0; i < 423; i++)
          {
           fg.Clear(Color.Black);  
           fg.DrawLine(chimneyPen, 0, 260, 355, 260);
           fg.DrawLine(chimneyPen, 350, 260, 350, 177);
           fg.DrawLine(chimneyPen, 345, 177, 500, 177);
           fg.DrawLine(chimneyPen, 495, 177, 495, 260);
           fg.DrawLine(chimneyPen, 490, 260, this.Width, 260);
           fg.FillEllipse(slayBrush, i, 5, 50, 25);
           Thread.Sleep(11);
          }

            // chimeny and gift
          for (int y = 0; y < 300; y++)
           {
            fg.Clear(Color.Black);
            fg.FillEllipse(slayBrush, x, 1, 50, 25);
            fg.DrawLine(chimneyPen, 0, 260, 355, 260);
            fg.DrawLine(chimneyPen, 350, 260, 350, 177);
            fg.DrawLine(chimneyPen, 345, 177, 500, 177);
            fg.DrawLine(chimneyPen, 495, 177, 495, 260);
            fg.DrawLine(chimneyPen, 490, 260, this.Width, 260);
            fg.FillRectangle(giftBrush, x, y, 10, 10);
            Thread.Sleep(11);
           }

          //gift explosion
          boom.Play();
          for (int pixels = 1; pixels < 101; pixels++)
           {
            fg.FillEllipse(flameBrush, x - pixels / 2, 300 - pixels / 2, 10 + pixels, 10 + pixels);
            Thread.Sleep(10);
            fg.FillEllipse(lightBrush, x - pixels / 2, 300 - pixels / 2, 10 + pixels, 10 + pixels);
            Thread.Sleep(10);
            fg.FillEllipse(giftBrush, x - pixels / 2, 300 - pixels / 2, 10 + pixels, 10 + pixels);
            Thread.Sleep(10);  
           }
       }
   }
}
