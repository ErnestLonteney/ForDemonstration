using System;
using System.IO;
using System.IO.Enumeration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;

namespace Rectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FileName = "Position.xml";
        private readonly XmlSerializer serializer;
        private Point position;
      
        public MainWindow()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(Point));
            mainCanvas.Focus();                 
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Right : Canvas.SetLeft(myRec, Canvas.GetLeft(myRec) + 10);
                    break;
                case Key.Left: Canvas.SetLeft(myRec, Canvas.GetLeft(myRec) - 10);   
                    break;
                case Key.Up: Canvas.SetTop(myRec, Canvas.GetTop(myRec) - 10);   
                    break;
                case Key.Down:
                    Canvas.SetTop(myRec, Canvas.GetTop(myRec) + 10);
                    break;
            }         
        }

        private void mainCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            position.X = Canvas.GetLeft(myRec);
            position.Y = Canvas.GetTop(myRec);

            SetTitle();
        }

        private void mainForm_Closed(object sender, EventArgs e)
        {
            var stream = File.Create(FileName);
            serializer.Serialize(stream, position);

            stream.Close(); 
        }

        private Point GetCurrentPosition()
        {
            if (File.Exists(FileName))
            {
                XmlReader xmlReader = null;

                try
                {
                    var stream = File.OpenRead(FileName);
                    xmlReader = new XmlTextReader(stream);
                    if (serializer.CanDeserialize(xmlReader))
                    {                       
                        return (Point)serializer.Deserialize(xmlReader);
                    }
                }
                catch 
                {
                    MessageBox.Show("Desearelization went wrong");
                }
                finally 
                {
                    xmlReader?.Close();
                }
            }          
             
            return new Point(Canvas.GetLeft(myRec), Canvas.GetTop(myRec));
        }

        private void SetTitle() => mainForm.Title = $"{position.X} {position.Y}";

        private void SetRectanglePosition(Point position)
        {
            Canvas.SetTop(myRec, position.Y);
            Canvas.SetLeft(myRec, position.X);
            
            SetTitle();
        }

        private void mainForm_Loaded(object sender, RoutedEventArgs e)
        {
            position = GetCurrentPosition();
            SetRectanglePosition(position);
        }
    }
}
