using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FreeGameIsAFreeGame.Core
{
    public interface IScraper
    {
        string Identifier { get; }
        Task Initialize(CancellationToken token);
        Task<IEnumerable<IDeal>> Scrape(CancellationToken token);
        Task Dispose();
    }
}
