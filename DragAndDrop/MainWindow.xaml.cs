using System.Windows;

namespace DragAndDrop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void File_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (filePaths != null && filePaths.Length > 0)
                {
                    foreach(string filePath in filePaths)
                        filesList.Items.Add(filePath);
                }
            }
        }
    }
}
