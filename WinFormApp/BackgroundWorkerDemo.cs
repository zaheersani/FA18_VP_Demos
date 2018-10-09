using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class BackgroundWorkerDemo : Form
    {
        public BackgroundWorkerDemo()
        {
            InitializeComponent();
            //TODO: Update this application to have 4 states:Start,Stop,Pause,Resume
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                //Console.WriteLine(i);
                //this.lblCounter.Text = i.ToString();
                System.Threading.Thread.Sleep(50);
                this.bgWorker.ReportProgress(i);
                if (this.bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblCounter.Text = e.ProgressPercentage.ToString();
            //TODO: Manage Percentage values when exceeding 100
            //this.progBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.lblStatus.Text = "Work Cancelled!";
                this.btnStart.Text = "Start";
            }
            else
            {
                this.lblStatus.Text = "Work Completed!";
                this.btnStart.Text = "Start";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (!this.bgWorker.IsBusy)
            {
                this.bgWorker.RunWorkerAsync();
                this.lblStatus.Text = "Working!";
                this.btnStart.Text = "Stop";
            }
            else
            {
                this.bgWorker.CancelAsync();
                this.btnStart.Text = "Start";
                //this.lblStatus.Text = "Working!";
            }
            
        }
    }
}
