namespace DailyProgrammerWebClient
{
    public interface IDissectedUrl
    {
        string Server { get; }
        string TLD { get; }
        string Protocol { get; }
        string Page { get; }

        void Dissect();
    }
}