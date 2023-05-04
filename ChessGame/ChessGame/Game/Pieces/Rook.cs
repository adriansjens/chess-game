using ChessGame.Game.PieceLogic;

namespace ChessGame.Pieces
{
    public class Rook : IChessPiece
    {
        public string Color { get; }
        public string UnicodeCharacter { get; }

        public Rook(string color)
        {
            Color = color;
            UnicodeCharacter = color == ChessColor.White ? "♖" : "♜";
        }

        public bool Move()
        {
            throw new NotImplementedException();
        }

        public bool RemovePiece()
        {
            throw new NotImplementedException();
        }
    }
}
