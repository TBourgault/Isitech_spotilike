using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotilike
{
    class Style
    {
        private string name;
        private int position;
        private bool isActive;

        public Style()
        {
            this.name = "unknow";
            this.position = 0;
            this.isActive = true;
        }

        public Style(string name, int position, bool isActive)
        {
            this.name = name;
            this.position = position;
            this.isActive = isActive;
        }
    }
}
