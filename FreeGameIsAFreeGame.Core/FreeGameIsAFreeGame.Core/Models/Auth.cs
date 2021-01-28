using System;

namespace FreeGameIsAFreeGame.Core.Models
{
    [Serializable]
    public class Auth : IAuth
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Key { get; set; }
        public DateTime Created { get; set; }
        public string Roles { get; set; }
    }
}