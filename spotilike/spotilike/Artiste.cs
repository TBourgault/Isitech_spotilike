using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotilike
{
    class Artiste
    {
        private string firstName;
        private string lastName;
        private string gender;
        private bool isGroup;
        private DateTime createdAt;
        private string country;

        public Artiste()
        {
            this.firstName = "unknow";
            this.lastName = "unknow";
            this.gender = "unknow";
            this.isGroup = false;
            this.createdAt = new DateTime();
            this.country = "unknow";
        }

        public Artiste(string firstName, string lastName, string gender, bool isGroup, DateTime createdAt, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.isGroup = isGroup;
            this.createdAt = createdAt;
            this.country = country;
        }
    }
}
