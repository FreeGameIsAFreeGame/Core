using System;

namespace FreeGameIsAFreeGame.Core
{
    public interface IAuth : IModel
    {
        string Owner { get; set; }
        string Key { get; set; }
        DateTime Created { get; set; }
        string Roles { get; set; }
    }
}
