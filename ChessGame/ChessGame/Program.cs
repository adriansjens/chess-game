using ChessGame;
using ChessGame.GameInterface;

internal class Program
{
    private static void Main(string[] args)
    {
        var gameInterface = new ConsoleChessGameInterface();

        var app = new ChessGameApplication(gameInterface);

        app.StartApplication();
    }
}