﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotilike
{
    class Musique
    {
        private string title;
        private string details;
        private DateTime date;
        private Artiste artiste;
        private Style style;
        

        // CONSTRUCT
        public Musique()
        {
            this.title = "unknow";
            this.details = "unknow";
            this.date = new DateTime();
        }

        public Musique(string title, string details, DateTime date)
        {
            this.title = title;
            this.details = details;
            this.date = date;
        }

        public Musique(string title, string details, DateTime date, Artiste artiste, Style style)
        {
            this.title = title;
            this.details = details;
            this.date = date;
            this.artiste = artiste;
            this.style = style;
        }


        // SETTERS AND GETTERS

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getDetails()
        {
            return this.details;
        }

        public void setDetails(string details)
        {
            this.details = details;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public Artiste getArtiste()
        {
            return this.artiste;
        }

        public void setArtiste(Artiste artistre)
        {
            this.artiste = artiste;
        }

        public Style getStyle()
        {
            return this.style;
        }

        public void setStyle(Style style)
        {
            this.style = style;
        }

        public string __toString()
        {
            // TODO
            return "TODO"
        }

    }
}
