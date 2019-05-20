using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.WebBrowsing
{
    public class NavigatingEventArgs
    {
        public string Url { get; set; }

        public bool Cancel { get; set; }
    }
}
