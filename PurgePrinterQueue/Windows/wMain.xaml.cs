using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PurgePrinterQueue.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private PrinterRoutines _printerRoutines;

        public MainWindow()
        {
            InitializeComponent();

            _printerRoutines = new PrinterRoutines();

            LoadPrintQueue();
        }

        private void miInfo_Click(object sender, RoutedEventArgs e)
        {
            var wInfo = new wInformation();
            wInfo.ShowDialog();
        }

        private void LoadPrintQueue()
        {
            this.spJobs.Children.Clear();

            var printQueue = _printerRoutines.PrinterQueueView();

            foreach (var job in printQueue)
            {
                this.spJobs.Children.Add(job);
            }
        }

        private void miRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadPrintQueue();
        }

        private async void miPurge_Click(object sender, RoutedEventArgs e)
        {
            cnStatus.Visibility = Visibility.Visible;
            lblStatus.Content = "Purging Printer Jobs...";
            await Task.Delay(1000);

            var purgeResult = await _printerRoutines.PrinterQueuePurge();

            if (!purgeResult)
            {
                lblStatus.Content = "Stopping Printer Spool Service...";
                if (await _printerRoutines.StopPrinterSpoolService())
                {
                    lblStatus.Content = "Deleting Printer Spool Files...";
                    await _printerRoutines.DeletePrinterSpoolFiles();
                }

                lblStatus.Content = "Starting Printer Spool Service...";
                if (await _printerRoutines.StartPrinterSpoolService())
                {
                    lblStatus.Content = "Successfully Started Service...";
                    await Task.Delay(1000);
                }
            }
            lblStatus.Content = "Exiting...";
            await Task.Delay(2000);
            cnStatus.Visibility = Visibility.Hidden;

            LoadPrintQueue();
        }
    }
}