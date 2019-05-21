using Panacea.Core;

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
