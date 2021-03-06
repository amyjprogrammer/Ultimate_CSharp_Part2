using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_CSharp_Part2
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public DateTime DateExpire { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key];  }
            set { _dictionary[key] = value;  }
        }
    }
}
