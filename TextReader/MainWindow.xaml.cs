using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
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
        private bool isCanceled = false;
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
                    isCanceled = false;
                    tbMain.Clear();
                    tbFileName.Text = dialog.FileName;

                    bool got = false;
                    pbMain.Visibility = Visibility.Visible;
                    pbMain.Value = 0;

                    try
                    {
                        _ = Task.Run(async () =>
                        {
                            while (!got)
                            {
                                await Task.Delay(1000);
                                await Dispatcher.InvokeAsync(() => pbMain.Value += 1);
                            }
                        },
                        cancellationSource.Token);

                        using StreamReader reader = new (dialog.FileName);

                        char[] buffer = new char[1024];

                        while ((await reader.ReadAsync(buffer, cancellationSource.Token)) > 0 && !isCanceled) 
                        {
                          //  cancellationSource.Token.ThrowIfCancellationRequested();    
                            if (buffer.Any())
                             tbMain.AppendText(new String(buffer));
                            await Task.Delay(100);
                        }           
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
            if (!isCanceled)
            {
                cancellationSource?.Cancel();
                cancellationSource = new CancellationTokenSource();
                tbFileName.Clear();
                isCanceled = true;
                MessageBox.Show("Reading was canceled");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cancel();
        }
    }
}
