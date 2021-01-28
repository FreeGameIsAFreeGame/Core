using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Platform : IPlatform
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string DisplayName { get; set; }
    }
}
