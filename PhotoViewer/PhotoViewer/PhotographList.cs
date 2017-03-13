// PhotoViewer - Final Project
// Jorge Montes - 3/7/2017
// Creating Client Applications in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhotoViewer
{
    public class PhotographList : List<Photograph>
    {
        /// <summary>
        /// PhotographList class to store list of Photograph objects
        /// </summary>
        public PhotographList()
        {
            /// <summary>
            /// PhotographList constructor used to preload a few photographs from included XML string
            /// </summary>
            string XMLFile = @"<Photographs>"
                           + @"<Photograph><Title>Christmas</Title><DateTaken>12/24/2014</DateTaken><Description>Christmas tree in 2014</Description><ArtistName>Jorge</ArtistName><Keywords>Christmas,tree,gifts,2014</Keywords><FileLocation>C:\3-CreatingClientApplications\Final Project\PhotoViewer\Images\Christmas.JPG</FileLocation></Photograph>"
                           + @"<Photograph><Title>Exorcist</Title><DateTaken>11/29/2015</DateTaken><Description>Attacked by demon-possessed Regan</Description><ArtistName>Girlfriend</ArtistName><Keywords>Exorcist,Regan,halloween,girlfriend,2015</Keywords><FileLocation>C:\3-CreatingClientApplications\Final Project\PhotoViewer\Images\Exorcist.JPG</FileLocation></Photograph>"
                           + @"<Photograph><Title>Girlfriend</Title><DateTaken>2/18/2017</DateTaken><Description>Shopping with girlfriend</Description><ArtistName>Jorge</ArtistName><Keywords>Girlfriend,shopping,hat,2017</Keywords><FileLocation>C:\3-CreatingClientApplications\Final Project\PhotoViewer\Images\Girlfriend.JPG</FileLocation></Photograph>"
                           + @"<Photograph><Title>Halloween</Title><DateTaken>11/29/2015</DateTaken><Description>Halloween custome for 2015</Description><ArtistName>Girlfriend</ArtistName><Keywords>Halloween,custome,girlfriend,2015</Keywords><FileLocation>C:\3-CreatingClientApplications\Final Project\PhotoViewer\Images\Halloween.JPG</FileLocation></Photograph>"
                           + @"<Photograph><Title>Helmet</Title><DateTaken>11/8/2014</DateTaken><Description>Motorcycle helmet</Description><ArtistName>Jorge</ArtistName><Keywords>Helmet,motorcycle,safety,2014</Keywords><FileLocation>C:\3-CreatingClientApplications\Final Project\PhotoViewer\Images\Helmet.JPG</FileLocation></Photograph>"
                           + @"</Photographs>";

            Regex XMLPattern = new Regex(@"^(\<Photographs\>)(\<Photograph\>)(.*)(\<\/Photograph\>)(\<Photograph\>)(.*)(\<\/Photograph\>)(\<Photograph\>)(.*)(\<\/Photograph\>)(\<Photograph\>)(.*)(\<\/Photograph\>)(\<Photograph\>)(.*)(\<\/Photograph\>)(\<\/Photographs\>)$");
            Match XMLMatch = XMLPattern.Match(XMLFile);

            int i = 0;
            while (i < 15)
            {
                i += 3;
                Regex PhotographPattern = new Regex(@"^(\<Title\>)(.*)(\<\/Title\>)(\<DateTaken\>)(.*)(\<\/DateTaken\>)(\<Description\>)(.*)(\<\/Description\>)(\<ArtistName\>)(.*)(\<\/ArtistName\>)(\<Keywords\>)(.*)(\<\/Keywords\>)(\<FileLocation\>)(.*)(\<\/FileLocation\>)");

                Match TitleMatch = PhotographPattern.Match(XMLMatch.Groups[i].ToString());
                Match DateTakenMatch = PhotographPattern.Match(XMLMatch.Groups[i].ToString());
                Match DescriptionMatch = PhotographPattern.Match(XMLMatch.Groups[i].ToString());
                Match ArtistNameMatch = PhotographPattern.Match(XMLMatch.Groups[i].ToString());
                Match KeywordsMatch = PhotographPattern.Match(XMLMatch.Groups[i].ToString());
                Match FileLocationMatch = PhotographPattern.Match(XMLMatch.Groups[i].ToString());

                // Add photograph to list
                Add(new Photograph(TitleMatch.Groups[2].ToString(), DateTime.Parse(DateTakenMatch.Groups[5].ToString()),
                    DescriptionMatch.Groups[8].ToString(), ArtistNameMatch.Groups[11].ToString(),
                    KeywordsMatch.Groups[14].ToString(), FileLocationMatch.Groups[17].ToString()));
            }
        }
        public void AddPhotograph(string title, DateTime dateTaken, string description, string artistName,
            string keywords, string fileLocation)
        {
            /// <summary>
            /// Method used by other objects to add photographs to the photographList object
            /// <param name="title">Photograph title</param>
            /// <param name="dateTaken">Date Photograph was taken</param>
            /// <param name="dateAdded">Date Photograph was added</param>
            /// <param name="description">Photograph description</param>
            /// <param name="artistName">Photograph artist name</param>
            /// <param name="keywords">Photograph keywords</param>
            /// <param name="fileLocation">Photograph file location</param>
            /// </summary>
            Add(new Photograph(title, dateTaken, description, artistName, keywords, fileLocation));
        }
    }
    public class DisplayList : List<Photograph>
    {
        /// <summary>
        /// DisplayList class used by other objects to add photographs to the displayList object
        /// </summary>
        /// <param name="title">Photograph title</param>
        /// <param name="dateTaken">Date Photograph was taken</param>
        /// <param name="dateAdded">Date Photograph was added</param>
        /// <param name="description">Photograph description</param>
        /// <param name="artistName">Photograph artist name</param>
        /// <param name="keywords">Photograph keywords</param>
        /// <param name="fileLocation">Photograph file location</param>
        /// <returns>Photograph object</returns>
        public void AddToDisplay(string title, DateTime dateTaken, string description, string artistName,
            string keywords, string fileLocation)
        {
            Add(new Photograph(title, dateTaken, description, artistName, keywords, fileLocation));
        }
    }
}
