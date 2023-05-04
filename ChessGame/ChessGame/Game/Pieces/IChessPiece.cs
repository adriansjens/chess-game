namespace ChessGame.Pieces
{
    public interface IChessPiece
    {
        public string UnicodeCharacter { get; }
        public Boolean Move();
        public Boolean RemovePiece();
    }
}
