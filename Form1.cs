using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace граф.элементы
{
    public partial class Form1 : Form

    {
        Rectangle Rectangle = new Rectangle(200, 10, 300, 200);
        RectangleF Circle = new RectangleF (200, 10, 200, 200);
        Point[] Triangle = { new Point(10, 30), new Point(270, 30), new Point(270, 30), new Point(260, 240), new Point(260, 240), new Point(10, 30) };
        Rectangle Square = new Rectangle(200,10,200,200);
        Rectangle Ellipse = new Rectangle(200,10,200,150);
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            if (listBox1.SelectedIndex == 0)
                g.FillRectangle(Brushes.Aquamarine, Square);
            if (listBox1.SelectedIndex == 1)
                g.FillEllipse(Brushes.CadetBlue, Circle);
            if (listBox1.SelectedIndex == 2)
                g.FillRectangle(Brushes.Pink, Rectangle);
            if (listBox1.SelectedIndex == 3)
                g.FillEllipse(Brushes.RoyalBlue, Ellipse);
            if (listBox1.SelectedIndex == 4)
                g.FillPolygon(Brushes.YellowGreen,Triangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            Pen myPen = new Pen(Color.LightGreen, 5);         
            if (listBox1.SelectedIndex == 0)
                g.DrawRectangle(myPen, Square);
            if (listBox1.SelectedIndex == 1)
                g.DrawEllipse(myPen, Circle);
            if (listBox1.SelectedIndex == 2)  
            g.DrawRectangle(myPen, Rectangle);
            if (listBox1.SelectedIndex == 3)
                g.DrawEllipse(myPen, Ellipse);
            if (listBox1.SelectedIndex == 4)
                g.DrawPolygon(myPen, Triangle);



        }
    }
}
