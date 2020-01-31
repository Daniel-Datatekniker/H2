using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTaskReal
{
    class Link
    {
        //Attribute
        private string path;

        //Properties
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        
        //Constructor
        public Link(string link)
        {
            Path = link;
        }

    }
}
