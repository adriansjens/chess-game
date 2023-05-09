using ChessGame.Game.PieceLogic;

namespace ChessGame.Pieces
{
    public class Pawn : IChessPiece
    {
        public string Color { get; }
        public IPieceMoveset Moveset { get; }
        public string UnicodeCharacter { get; }

        public Pawn(string color, IPieceMoveset moveset)
        {
            Color = color;
            Moveset = moveset;
            UnicodeCharacter = color == ChessColor.White ? "♙" : "♟︎";
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
