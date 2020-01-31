using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTaskReal
{
    class RequestHandler
    {
        //Attribute
        private Link path;
        private IRequest iRequest;


        //Properties
        public Link Path
        {
            get { return path; }
            private set { path = value; }
        }

        public IRequest IRequest
        {
            get { return iRequest; }
            private set { iRequest = value; }
        }

        //Constructor
        public RequestHandler(IRequest requestType, Link pathWay)
        {
            iRequest = requestType;
            path = pathWay;
        }

        //Methods
        public string Request()
        {
            return IRequest.Request(Path);
        }

    }
}
