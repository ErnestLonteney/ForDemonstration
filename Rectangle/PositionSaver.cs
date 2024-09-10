using System;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace Rectangle
{
    internal static class PositionSaver
    {
        private const string FileName = "Position.xml";
        private static readonly XmlSerializer serializer;

        static PositionSaver()
        {
            serializer = new XmlSerializer(typeof(Point));    
        }

        public static void SavePosition(Point position)
        {
            FileStream? stream = null;

            try
            {
                stream = File.Create(FileName);
                serializer.Serialize(stream, position);
            }
            catch (Exception)
            {
                throw;                 
            }
            finally
            {
                stream?.Close();
            }         
        }

        public static Point GetPosition()
        {
            if (File.Exists(FileName))
            {
                XmlReader? xmlReader = null;

                try
                {
                    var stream = File.OpenRead(FileName);
                    xmlReader = new XmlTextReader(stream);
                    if (serializer.CanDeserialize(xmlReader))
                    {
                        return (Point)serializer.Deserialize(xmlReader);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    xmlReader?.Close();
                }
            }

            return new Point(); 
        }
    }
}
