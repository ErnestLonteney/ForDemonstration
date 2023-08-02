using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ReaderExample.Convetors
{
    public class TextToImageConverter : IValueConverter
    {
        public static ImageSource TextToImage(string fileName)
        {
            if (fileName == null)
                return null;

            var imageData = File.ReadAllBytes(Path.Combine("Resources", fileName));
            var biImg = new BitmapImage();
            var ms = new MemoryStream(imageData);
            biImg.BeginInit();
            biImg.StreamSource = ms;
            biImg.EndInit();

            ImageSource imgSrc = biImg;

            return imgSrc;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => TextToImage(value as string);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
