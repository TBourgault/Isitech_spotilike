using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotilikeClient.Models
{
    class Style
    {
        private string name;
        private int position;
        private bool isActive;

        // Constructor
        public Style()
        {
            this.name = "unknow";
            this.position = 0;
            this.isActive = true;
        }

        public Style(string name, int position)
        {
            this.name = name;
            this.position = position;
            this.isActive = true;
        }

        public Style(string name, int position, bool isActive)
        {
            this.name = name;
            this.position = position;
            this.isActive = isActive;
        }

        // GETTERS & SETTERS
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getPosition()
        {
            return this.position;
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public bool getIsActive()
        {
            return this.isActive;
        }

        public void setIsActive(bool isActive)
        {
            this.isActive = isActive;
        }
    }
}
