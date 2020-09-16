using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FreeGameIsAFreeGame.Core.Models;

namespace FreeGameIsAFreeGame.Core
{
    public interface IScraper
    {
        string Identifier { get; }
        string DisplayName { get; }
        Task<IEnumerable<IDeal>> Scrape(CancellationToken token);
    }
}
