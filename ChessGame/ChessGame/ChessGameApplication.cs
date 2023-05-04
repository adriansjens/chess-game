using ChessGame.Game;
using ChessGame.Game.PieceLogic;
using ChessGame.GameInterface;

namespace ChessGame
{
    internal class ChessGameApplication
    {
        private IChessGameInterface _gameInterface;
        
        public ChessGameApplication(IChessGameInterface gameInterface) 
        {
            _gameInterface = gameInterface;
        }

        public void StartApplication()
        {
            var applicationRunning = true;
            while (applicationRunning) 
            {
                _gameInterface.RenderMenu();

                var userAction = _gameInterface.GetMenuChoiceFromUser();
                if (userAction == MenuOptions.NewGame)
                {
                    StartNewGame();
                    continue;
                }

                _gameInterface.Exit();

                applicationRunning = false;
            }
        }

        private void StartNewGame()
        {
            var chessPieceFactory = new ChessPieceFactory();   

            var board = new Board(chessPieceFactory);
            var initialBoardState = board.PerformGameSetup();   

            var game = new GameContext(board, _gameInterface);

            var gameFinished = false;
            while (!gameFinished)
            {
                gameFinished = true;
            }
        }

        private void EndGame()
        {
            throw new NotImplementedException();
        }
    }
}
