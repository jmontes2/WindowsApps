// PhotoViewer - Final Project
// Jorge Montes - 3/7/2017
// Creating Client Applications in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    public class Photograph
    {
        /// <summary>
        /// Photograph class to maintain Photograph data
        /// </summary>

        private String title;
        private DateTime dateTaken;
        private DateTime dateAdded;
        private String description;
        private String artistName;
        private String keywords;
        private String fileLocation;
        public Photograph (String title, DateTime dateTaken, String description,
            String artistName, String keywords, String fileLocation)
        {
            /// <summary>
            /// Constructor to create Photograph object
            /// </summary>
            /// <param name="title">Photograph title</param>
            /// <param name="dateTaken">Date Photograph was taken</param>
            /// <param name="dateAdded">Date Photograph was added</param>
            /// <param name="description">Photograph description</param>
            /// <param name="artistName">Photograph artist name</param>
            /// <param name="keywords">Photograph keywords</param>
            /// <param name="fileLocation">Photograph file location</param>
            /// <returns>Photograph object</returns>
            Title = title;
            DateTaken = dateTaken;
            DateAdded = DateTime.Now;       // DateTime stamp
            Description = description;
            ArtistName = artistName;
            Keywords = keywords;
            FileLocation = fileLocation;
        }

        // Properties
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public DateTime DateTaken
        {
            get { return dateTaken; }
            set { dateTaken = value; }
        }
        public String DateTakenString
        {
            // Used to display date only
            get { return dateTaken.ToShortDateString(); }
        }
        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        public String ArtistName
        {
            get { return artistName; }
            set { artistName = value; }
        }
        public String Keywords
        {
            get { return keywords; }
            set { keywords = value; }
        }
        public String FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }
        public override string ToString()
        {
            /// <summary>
            /// Override ToString method for display, although not used
            /// </summary>
            return Title.ToString() + "\t" + DateTaken.ToShortDateString() + "\t" + Description.ToString();
        }
    }
}
