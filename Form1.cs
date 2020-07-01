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
                    Sequential_Operations();
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
            Cursor.Position = new Point(2000, 50); 
            MouseAndKey.LeftMouseClick(Cursor.Position);
            Cursor.Position = new Point(2400, 450);
            MouseAndKey.LeftMouseClick(Cursor.Position);
            Cursor.Position = new Point(3070, 500);
            MouseAndKey.LeftMouseClick(Cursor.Position);
            Task.Delay(1000);
            Cursor.Position = new Point(3070, 570);
            MouseAndKey.LeftMouseClick(Cursor.Position);


        }
    }
}
