using System.Collections.Generic;

namespace Panacea.Modularity.WebBrowsing
{
    public interface IWebBrowserPlugin:IPlugin
    {
        void OpenUrl(string url);

        void OpenUnmanaged(string url, IWebViewManager manager, bool blockDomains = true, List<string> allowedDomains = null);
    }
}
