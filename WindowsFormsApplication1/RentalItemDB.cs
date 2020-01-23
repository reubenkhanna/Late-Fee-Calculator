using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WindowsFormsApplication1;

namespace RentalMaintenance
{
    public static class RentalItemDB
    {
        private const string Path = @"..\..\RentalItems.xml";

        public static List<RentalItem> GetMovies()
        {
            // create the list
            List<RentalItem> movies = new List<RentalItem>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Book node
            if (xmlIn.ReadToDescendant("Movie"))
            {
                // create one Product object for each Product node
                do
                {
                    RentalItem movie = new RentalItem();
                    xmlIn.ReadStartElement("Movie");
                    movie.MovieNo = xmlIn.ReadElementContentAsInt();
                    movie.Description = xmlIn.ReadElementContentAsString();
                    movie.Rating = xmlIn.ReadElementContentAsString();
                    movies.Add(movie);
                }
                while (xmlIn.ReadToNextSibling("Movie"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return movies;
        }

        public static void SaveMovies(List<RentalItem> movies)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Movies");

            // write each product object to the xml file
            foreach (RentalItem movie in movies)
            {
                xmlOut.WriteStartElement("Movie");
                xmlOut.WriteElementString("MovieNo", Convert.ToString(movie.MovieNo));
                xmlOut.WriteElementString("Description", movie.Description);
                xmlOut.WriteElementString("Rating", movie.Rating);
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
