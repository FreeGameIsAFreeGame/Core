namespace FreeGameIsAFreeGame.Core
{
    public interface IPlatform
    {
        int Id { get; set; }
        string Identifier { get; set; }
        string DisplayName { get; set; }
    }
}