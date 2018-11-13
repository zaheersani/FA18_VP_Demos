using System.Windows;
using System;

using System.ComponentModel;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerInWPF.xaml
    /// </summary>
    public partial class BackgroundWorkerInWPF : Window
    {
        BackgroundWorker bg = new BackgroundWorker();
        public BackgroundWorkerInWPF()
        {
            InitializeComponent();
            bg.WorkerReportsProgress = true;
            bg.WorkerSupportsCancellation = true;
            bg.DoWork += bg_DoWork;
            bg.ProgressChanged += bg_ProgressChanged;
        }

        void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblCounter.Content = e.ProgressPercentage;
        }

        int i = 0;
        void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            for ( ; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(100);
                bg.ReportProgress(i);
                Console.WriteLine(i);
                if (bg.CancellationPending)
                    break;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (!bg.IsBusy)
                bg.RunWorkerAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bg.CancelAsync();
        }
    }
}
