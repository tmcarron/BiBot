using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;

namespace BiBot
{
    public partial class Form1 : Form
    {
        bool isInitiated;
        public Form1()
        {
            InitializeComponent();
            isInitiated = false;
        }

        private void Initiate_Button_Click(object sender, EventArgs e)
        {
            if(isInitiated == false)
            {
                isInitiated = true;

                if (reporterBGWorker.IsBusy == false)
                {
                    Initiate_Button.Text = "INITIATING";
                    reporterBGWorker.RunWorkerAsync();
                    SequenceBGWorker.RunWorkerAsync();
                }
            }
            else if(isInitiated == true)
            {
                
                isInitiated = false;
                Initiate_Button.Text = "Inititate";
                reporterBGWorker.CancelAsync();
            }
        }

        private void reporterBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (isInitiated == true)
            {    
                MousePositionXbox.Text = "Mouse Postition X = " + Cursor.Position.X;
                MousePositionYbox.Text = "Mouse Postition Y = " + Cursor.Position.Y;
            }
        }
        private void Sequential_Operations()
        {
            Point[] points = { new Point(2000, 50), new Point(3000,450), new Point(3070,500),
                            new Point(3370,570), new Point(3630,930),new Point(2000, 50) };
            Point[] fillPoints = { new Point(2353, 588) };
            string[] autofill = { "TEST" };

            AutoClick(points);
            AutoClick(fillPoints, autofill);
            

        }
        private void AutoClick(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Thread.Sleep(1000);
                if (i == 4) { Thread.Sleep(250); }
                Cursor.Position = points[i];
                MouseAndKey.LeftMouseClick(Cursor.Position);
                textBox1.Text = Convert.ToString(i);

            }
        }
        private void AutoClick(Point[] points, string[] autofill)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Thread.Sleep(1000);
                if (i == 4) { Thread.Sleep(1000); }
                Cursor.Position = points[i];
                MouseAndKey.LeftMouseClick(Cursor.Position);
                Thread.Sleep(1000);
                SendKeys.Send(autofill[i]);
                textBox1.Text = Convert.ToString(i);


            }
        }
        private void SequenceBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Sequential_Operations();
        }
    }
}
