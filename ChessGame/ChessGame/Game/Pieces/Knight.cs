using ChessGame.Game.PieceLogic;

namespace ChessGame.Pieces
{
    public class Knight : IChessPiece
    {
        public string Color { get; }
        public string UnicodeCharacter { get; }

        public Knight(string color) 
        {
            Color = color;
            UnicodeCharacter = color == ChessColor.White ? "♘" : "♞";
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
