using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Platform
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string DisplayName { get; set; }
    }
}
