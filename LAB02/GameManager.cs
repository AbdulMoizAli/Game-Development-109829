public sealed class GameManager
{
    public int leftPlayerScore;
    public int rightPlayerScore;

    static volatile GameManager gameManager;
    static readonly object syncLock = new object();

    private GameManager() { }

    public static GameManager GetGameManager()
    {
        if (gameManager is not null)
            return gameManager;

        lock (syncLock)
            if (gameManager is null)
                gameManager = new GameManager();

        return gameManager;
    }
}
