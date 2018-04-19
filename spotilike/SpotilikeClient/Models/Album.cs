using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotilikeClient.Models
{
    class Album
    {
        private string title;
        private float duration;
        private DateTime publishedAt;
        private Artiste artiste;
        private Style style;
        private List<Musique> musiques;
        private int id;

        // CONSTRUCTEUR
        public Album()
        {
            this.title = "";
            this.duration = 0;
            this.publishedAt = new DateTime();
            this.artiste = new Artiste();
            this.style = new Style();
            this.musiques = new List<Musique>();
        }

        public Album(string title, float duration, Artiste artiste, Style style)
        {
            this.title = title;
            this.duration = duration;
            this.artiste = artiste;
            this.style = style;
            this.publishedAt = DateTime.Now;
            this.musiques = new List<Musique>();
        }

        public Album(string title, float duration, Artiste artiste, Style style, DateTime publishedAt) {
            this.title = title;
            this.duration = duration;
            this.publishedAt = publishedAt;
            this.artiste = artiste;
            this.style = style;
            this.musiques = new List<Musique>();
        }

        // GETTERS & SETTERS
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public float getDuration()
        {
            return this.duration;
        }

        public void setDuration(float duration)
        {
            this.duration = duration;
        }

        public DateTime getPublishedAt()
        {
            return this.publishedAt;
        }

        public void setPublishedAt(DateTime publishedAt)
        {
            this.publishedAt = publishedAt;
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

        public List<Musique> getMusiques()
        {
            return this.musiques;
        }

        public void addMusique(Musique musique)
        {
            this.musiques.Add(musique);
        }

        public void removeMusique(Musique musique)
        {
            this.musiques.Remove(musique);
        }
    }
}
