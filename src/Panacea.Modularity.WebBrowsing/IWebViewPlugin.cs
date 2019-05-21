using System.Threading.Tasks;

namespace Panacea.Modularity.WebBrowsing
{
    public interface IWebViewPlugin : IPlugin
    {
        Task<IWebViewManager> GetWebViewManagerAsync();
    }
}
