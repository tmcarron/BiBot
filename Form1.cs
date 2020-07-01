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
            Cursor.Position = textBox1.Location;
            textBox1.Text = textBox1.Location.ToString();
        }
    }
}
