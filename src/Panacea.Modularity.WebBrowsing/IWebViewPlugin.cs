﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.WebBrowsing
{
    public interface IWebViewPlugin : IPlugin
    {
        Task<IWebViewManager> GetWebViewManagerAsync();
    }
}
