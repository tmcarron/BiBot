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
using System.Drawing.Imaging;
using System.Collections;

namespace BiBot
{
    public partial class Form1 : Form
    {
        bool isInitiated;
        public ClickActions EricEman = new ClickActions();
        
        int sleepTime = 20;
        
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
                    Initiate_Button.Text = "EXECUTING";
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
            //points for the mouse to click
            int[] pointsOfRefresh = { };
            Point[] clickPoints = { new Point(3180,500), new Point(3370,570), new Point(3630,930), new Point(3829,967),new Point(2365,586)};
            Point[] fillPoints = { new Point(2353, 588) };
            string[] autofill = { "TEST" };

            AutoClick(clickPoints);
            
            

        }
        private void AutoClick(Point[] points)
        {
            
            //Making sure clothing order is in the correct size
            if(smallRadio.Checked == true)
            {
                points[0] = new Point(3075, 500);
            }
            else if (medRadio.Checked == true)
            {
                points[0] = new Point(3127, 500);
            }
            else if (xlRadio.Checked == true)
            {
                points[0] = new Point(3232, 500);
            }
            else if (xxlRadio.Checked == true)
            {
                points[0] = new Point(3286, 500);
            }


            
            for (int i = 0; i < points.Length; i++)
            {
                //Checking if an interuption check is necessary 

                for(int j = 0; j < EricEman.interuptionStep.Count; j++)
                {
                    if(i == EricEman.interuptionStep[j])
                    {
                        CheckRefresh(j);
                    }
                }
                Thread.Sleep(sleepTime);
                Cursor.Position = points[i];
                MouseAndKey.LeftMouseClick(Cursor.Position);
                textBox1.Text = Convert.ToString(i);

            }
        }
        public void CheckRefresh(int stepNum)
        {
            
            for(int i = 0; ; i++)
            {
                if(isInitiated == false) { break; }
                //Hard-coded to work on my second monitor. Will change eventually
                Bitmap bmpScreenshot = new Bitmap(Screen.AllScreens[1].Bounds.Width, Screen.AllScreens[1].Bounds.Height, PixelFormat.Format32bppArgb);
                Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                gfxScreenshot.CopyFromScreen(Screen.AllScreens[1].Bounds.X, Screen.AllScreens[1].Bounds.Y, 0, 0, Screen.AllScreens[1].Bounds.Size,
                    CopyPixelOperation.SourceCopy);

                Thread.Sleep(sleepTime);
                Color refreshColor = bmpScreenshot.GetPixel(EricEman.interuptionPoints[stepNum].X,EricEman.interuptionPoints[stepNum].Y);
                textBox2.Text = "Red Value: "+refreshColor.R+" < "+EricEman.colorValueCheck[stepNum]+" Sleep Time Units: "+i+" Location: "+EricEman.interuptionPoints[stepNum];
                
                if(refreshColor.R < EricEman.colorValueCheck[stepNum]) { break; }       
            }
            
        }
        private void SequenceBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Sequential_Operations();
            
        }

    }
}
