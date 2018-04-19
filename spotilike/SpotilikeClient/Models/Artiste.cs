using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotilikeClient.Models
{
    class Artiste
    {
        private int id;
        private string firstName;
        private string lastName;
        private string gender;
        private bool isGroup;
        private DateTime createdAt;
        private string country;


        // CONSTRUCT
        public Artiste()
        {
            this.firstName = "unknow";
            this.lastName = "unknow";
            this.gender = "unknow";
            this.isGroup = false;
            this.createdAt = DateTime.Now;
            this.country = "unknow";
        }

        public Artiste(string lastName, bool isGroup, string country)
        {
            this.lastName = lastName;
            this.isGroup = isGroup;
            this.country = country;
            this.firstName = "";
            this.gender = "";
            this.createdAt = DateTime.Now;
        }

        public Artiste(string firstName, string lastName, string gender, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.isGroup = false;
            this.createdAt = DateTime.Now;
            this.country = country;
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

        // GETTERS & SETTERS
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public bool getIsGroup()
        {
            return this.isGroup;
        }

        public void setIsGroup(bool isGroup)
        {
            this.isGroup = isGroup;
        }

        public DateTime getCreatedAt()
        {
            return this.createdAt;
        }

        public void setCreatedAt(DateTime createdAt)
        {
            this.createdAt = createdAt;
        }

        public string getCountry()
        {
            return this.country;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }

        // Get fullName of an artiste
        public string getFullName(string length)
        {
            string fullName = "";
            if (length == "short")
            {
                if (this.firstName.Length > 0)
                {
                    if (this.lastName.Length > 0)
                    {
                        fullName = this.firstName.Substring(0, 1) + this.lastName;
                    }
                    else
                    {
                        fullName = this.firstName;
                    }
                } else
                {
                    fullName = (this.lastName.Length > 0) ? this.lastName : "";
                }
            } else if (length == "medium")
            {
                if (this.firstName.Length > 0)
                {
                    if(this.lastName.Length > 0)
                    {
                        fullName = this.firstName + this.lastName;
                    } else
                    {
                        fullName = (this.gender.Length > 0) ? this.gender + this.firstName : this.firstName;
                    }
                } else
                {
                    if(this.lastName.Length > 0)
                    {
                        fullName = (this.gender.Length > 0) ? this.gender + this.lastName : this.lastName;
                    }
                }
            }

            return fullName;
        }

    }
}
