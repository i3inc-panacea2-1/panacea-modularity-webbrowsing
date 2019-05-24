using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.WebBrowsing
{
    public static class PanaceaServicesExtensions
    {
        public static IWebBrowserPlugin GetWebBrowser(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IWebBrowserPlugin>();
        }

        public static bool TryGetWebBrowser(this PanaceaServices core, out IWebBrowserPlugin plugin)
        {
            plugin = null;
            var webbrowser = core.PluginLoader.GetPlugins<IWebBrowserPlugin>().FirstOrDefault();
            if(webbrowser == null)
            {
                return false;
            }
            plugin = webbrowser;
            return true;
        }

    }
}
