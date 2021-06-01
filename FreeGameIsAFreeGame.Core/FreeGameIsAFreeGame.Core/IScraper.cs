using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FreeGameIsAFreeGame.Core
{
    public interface IScraper : IDisposable
    {
        string Identifier { get; }
        string DisplayName { get; }
        Task<IEnumerable<IDeal>> Scrape(CancellationToken token);
    }
}
