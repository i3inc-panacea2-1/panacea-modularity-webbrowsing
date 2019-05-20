using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.WebBrowsing
{
    public static class PanaceaServicesExtensions
    {
        public static IWebBrowserPlugin GetWebBrowser(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IWebBrowserPlugin>();
        }
    }
}
