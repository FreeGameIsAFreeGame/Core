using System;

namespace FreeGameIsAFreeGame.Core
{
    public interface IDeal
    {
        int Id { get; set; }
        int PlatformId { get; set; }
        string Title { get; set; }
        string Link { get; set; }
        string Image { get; set; }
        int Discount { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}
