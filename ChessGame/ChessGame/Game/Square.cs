using ChessGame.Pieces;

namespace ChessGame.Game
{
    public class Square
    {
        public string Designation { get; }
        public string Color { get; }
        public IChessPiece? CurrentPiece { get; set; }

        public Square(string designation, string color, IChessPiece? chessPiece)
        {
            Designation = designation;
            CurrentPiece = chessPiece;
            Color = color;
        }
    }
}
