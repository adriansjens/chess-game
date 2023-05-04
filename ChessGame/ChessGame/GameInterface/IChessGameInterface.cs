using ChessGame.Game;

namespace ChessGame.GameInterface
{
    public interface IChessGameInterface
    {
        public void RenderMenu();
        public string GetMenuChoiceFromUser();
        public bool MakeMove();
        public void RenderBoardState(List<Square> squares);
        public void Exit();
    }
}
