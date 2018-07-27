using System.Windows.Controls;

namespace ResetPrinterQueue.UserControls
{
    /// <summary>
    /// Interaction logic for uJob.xaml
    /// </summary>
    public partial class uJob : UserControl
    {
        public uJob()
        {
            InitializeComponent();
        }

        public uJob(string documentName, string documentInfo)
        {
            InitializeComponent();

            lblDocumentName.Content = $"Name : {documentName}";
            lblDocumentInformation.Content = $"Details : {documentInfo}";
        }
    }
}