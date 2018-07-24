using ResetPrinterQueue.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PurgePrinterQueue
{
    public class PrinterRoutines
    {
        private ServiceController _service;

        public PrinterRoutines()
        {
            _service = new ServiceController("Spooler");
        }

        public async Task<bool> PrinterQueuePurge()
        {
            await Task.Delay(1000);

            bool purgeSucceeded = true;

            try
            {
                PrintServer printServer = new PrintServer();
                PrintQueueCollection printQueues = printServer.GetPrintQueues();

                foreach (PrintQueue pq in printQueues)
                {
                    if (pq.NumberOfJobs > 0)
                    {
                        pq.Refresh();
                        PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();

                        try
                        {
                            pq.Purge();
                        }
                        catch (Exception)
                        {
                            purgeSucceeded = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                purgeSucceeded = false;
            }

            return purgeSucceeded;
        }

        public async Task<bool> StartPrinterSpoolService()
        {
            await Task.Delay(1000);

            try
            {
                _service.Start();
                _service.WaitForStatus(ServiceControllerStatus.Running);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public async Task<bool> StopPrinterSpoolService()
        {
            await Task.Delay(1000);

            try
            {
                if ((!_service.Status.Equals(ServiceControllerStatus.Stopped)) && (!_service.Status.Equals(ServiceControllerStatus.StopPending)))
                {
                    _service.Stop();
                    _service.WaitForStatus(ServiceControllerStatus.Stopped);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public async Task DeletePrinterSpoolFiles()
        {
            await Task.Delay(1000);

            string spoolDirectory = $"{Environment.SystemDirectory}\\spool\\printers\\";

            System.IO.DirectoryInfo di = new DirectoryInfo(spoolDirectory);

            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public List<uJob> PrinterQueueView()
        {
            List<uJob> printJobs = new List<uJob>();

            try
            {
                PrintServer printServer = new PrintServer();
                PrintQueueCollection printQueues = printServer.GetPrintQueues();

                foreach (PrintQueue pq in printQueues)
                {
                    if (pq.NumberOfJobs > 0)
                    {
                        pq.Refresh();
                        PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();

                        foreach (PrintSystemJobInfo job in jobs)
                        {
                            uJob printJob = new uJob(job.Name, $"{pq.Name} | {job.JobName} | {job.JobIdentifier}");
                            printJobs.Add(printJob);
                        }
                    }
                }
            }
            catch (Exception)
            {
                uJob printJob = new uJob("Print Spooler Service", $"An error occurred while loading the Print Jobs.");
                printJobs.Add(printJob);
            }

            return printJobs;
        }
    }
}