using ChessGame.GameInterface;

namespace ChessGame.Game
{
    public class GameContext
    {
        private Board _board;
        private IChessGameInterface _gameInterface;

        public GameContext(Board board, IChessGameInterface gameInterface) 
        {
            _board = board;
            _gameInterface = gameInterface;
        }
    }
}
