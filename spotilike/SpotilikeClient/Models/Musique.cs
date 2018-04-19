﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotilikeClient.Models
{
    class Musique
    {
        private string title;
        private string details;
        private DateTime date;
        private Artiste artiste;
        private Style style;
        private Album album;
        public string path;
        

        // CONSTRUCT
        public Musique()
        {
            this.title = "unknow";
            this.details = "unknow";
            this.date = new DateTime();
            this.path = "";
        }

        public Musique(string title, string details, DateTime date)
        {
            this.title = title;
            this.details = details;
            this.date = date;
            this.path = "";
        }

        public Musique(string title, string details, DateTime date, Artiste artiste, Style style, Album album, string path)
        {
            this.title = title;
            this.details = details;
            this.date = date;
            this.artiste = artiste;
            this.style = style;
            this.album = album;
            this.path = path;
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

        public void setArtiste(Artiste artiste)
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

        public Album getAlbum()
        {
            return this.album;
        }

        public void setAlbum(Album album)
        {
            this.album = album;
        }

        public string getPath()
        {
            return this.path;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        public string __toString()
        {
            // TODO
            return "TODO";
        }
    }
}
