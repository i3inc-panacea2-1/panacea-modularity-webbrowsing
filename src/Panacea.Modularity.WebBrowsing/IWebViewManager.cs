using System.Threading.Tasks;

namespace Panacea.Modularity.WebBrowsing
{
    public interface IWebViewManager
    {
        IWebView CreateTab(string url = null);

        Task ClearCookies();
    }
}
