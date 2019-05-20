using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.WebBrowsing
{
    public interface IWebView : IDisposable
    {

        bool CanGoBack { get; }
        event EventHandler<bool> CanGoBackChanged;

        bool CanGoForward { get; }
        event EventHandler<bool> CanGoForwardChanged;

        string Title { get; }
        event EventHandler<string> TitleChanged;

        string Url { get; }
        event EventHandler<string> UrlChanged;

        bool IsBusy { get; }
        event EventHandler<bool> IsBusyChanged;

        bool IsFullscreen { get; set; }
        event EventHandler<bool> FullscreenChanged;
        
        event EventHandler<string> NewWindow;
        event EventHandler<string> ElementFocus;
        event EventHandler ElementLostFocus;
        event EventHandler<NavigatingEventArgs> Navigating;
        event EventHandler<string> Navigated;
        
        
        event EventHandler DocumentLoaded;
        event EventHandler Close;


        void Navigate(string url);

        void CreateThumbnail();

        bool Focus();

        void GoBack();

        void GoForward();

        Task ExecuteJavaScriptAsync(string script);

        void ScrollUp(int lines);
        void ScrollDown(int lines);

    }
}
