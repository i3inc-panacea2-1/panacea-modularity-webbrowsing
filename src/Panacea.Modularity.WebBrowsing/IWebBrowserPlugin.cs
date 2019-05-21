using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.WebBrowsing
{
    public interface IWebBrowserPlugin:IPlugin
    {
        void OpenUrl(string url);

        FrameworkElement CreateUnmanagedTab(IWebViewManager manager, bool blockDomains = true, List<string> allowedDomains = null);
    }
}
