using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDiff
{
    class FileData
    {
        //Setting private properties
        private string _name;
        private string[] _content;
        private string _error = "";

        //Setting public methods for the above
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string[] Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
    }
}
