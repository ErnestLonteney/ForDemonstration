using Microsoft.Win32;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TextReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource cancellationSource;
        public MainWindow()
        {
            InitializeComponent();
            cancellationSource = new CancellationTokenSource();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                if (dialog.FileName != null)
                {
                    tbMain.Clear();
                    tbFileName.Text = dialog.FileName;

                    bool got = false;
                    pbMain.Visibility = Visibility.Visible;
                    pbMain.Value = 0;

                    try
                    {                    
                        Task.Run(async () =>
                        {
                            while (!got)
                            {
                                await Task.Delay(1000);
                                Dispatcher.Invoke(() => pbMain.Value += 10);
                            }
                        },
                        cancellationSource.Token);

                        string text = await File.ReadAllTextAsync(dialog.FileName, cancellationSource.Token);
                        tbMain.Text = text;                                      
                    }
                    catch (OperationCanceledException)
                    {
                        MessageBox.Show("Downloading was canceled");
                    }
                    finally
                    {
                        got = true;
                        Cancel();
                        pbMain.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }

        private void Cancel()
        {
            cancellationSource?.Cancel();
            cancellationSource?.Dispose();
            cancellationSource = new CancellationTokenSource();
            tbFileName.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cancellationSource?.Cancel();
            cancellationSource?.Dispose();
            cancellationSource = new CancellationTokenSource();
        }
    }
}
