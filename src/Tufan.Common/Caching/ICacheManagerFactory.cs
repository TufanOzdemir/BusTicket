using System;
using System.Collections.Generic;
using System.Text;

namespace Tufan.Common.Caching
{
    public interface ICacheManagerFactory
    {
        ICacheManagerService GetCacheManagerService(string key);
    }
}
