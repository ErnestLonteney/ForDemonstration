using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Rectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private Point currentPosition;
        public MainWindow()
        {
            InitializeComponent();
            mainCanvas.Focus();                 
        }          
        private void SetTitle() => mainForm.Title = $"{currentPosition.X} {currentPosition.Y}";
        private void SetRectanglePosition()
        {
            Canvas.SetTop(myRec, currentPosition.Y);
            Canvas.SetLeft(myRec, currentPosition.X);
            
            SetTitle();
        }

        #region Handlers
        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Right:
                    Canvas.SetLeft(myRec, Canvas.GetLeft(myRec) + 10);
                    break;
                case Key.Left:
                    Canvas.SetLeft(myRec, Canvas.GetLeft(myRec) - 10);
                    break;
                case Key.Up:
                    Canvas.SetTop(myRec, Canvas.GetTop(myRec) - 10);
                    break;
                case Key.Down:
                    Canvas.SetTop(myRec, Canvas.GetTop(myRec) + 10);
                    break;
            }
        }

        private void mainForm_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                currentPosition = PositionSaver.GetPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetRectanglePosition();
        }

        private void mainCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            currentPosition.X = Canvas.GetLeft(myRec);
            currentPosition.Y = Canvas.GetTop(myRec);

            SetTitle();
        }

        private void mainForm_Closed(object sender, EventArgs e)
        {
            try
            {
                PositionSaver.SavePosition(currentPosition);
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
