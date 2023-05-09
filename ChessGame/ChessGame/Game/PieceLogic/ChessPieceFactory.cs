using ChessGame.Game.Constants;
using ChessGame.Pieces;

namespace ChessGame.Game.PieceLogic
{
    public class ChessPieceFactory
    {
        private Dictionary<string, IChessPiece> _chessPieces = new()
        {
            { "a1", new Rook(ChessColor.White) },
            { "h1", new Rook(ChessColor.White) },
            { "b1", new Knight(ChessColor.White) },
            { "g1", new Knight(ChessColor.White) },
            { "c1", new Bishop(ChessColor.White) },
            { "f1", new Bishop(ChessColor.White) },
            { "d1", new Queen(ChessColor.White) },
            { "e1", new King(ChessColor.White) },
            { "a8", new Rook(ChessColor.Black) },
            { "h8", new Rook(ChessColor.Black) },
            { "b8", new Knight(ChessColor.Black) },
            { "g8", new Knight(ChessColor.Black) },
            { "c8", new Bishop(ChessColor.Black) },
            { "f8", new Bishop(ChessColor.Black) },
            { "d8", new Queen(ChessColor.Black) },
            { "e8", new King(ChessColor.Black) },
        };
        
        public ChessPieceFactory() 
        {
            CreatePawns();
        }

        public IChessPiece? GetChessPieceForSquare(string squareDesignation)
        {
            return _chessPieces.FirstOrDefault(keyValuePair => keyValuePair.Key == squareDesignation).Value;
        }

        private void CreatePawns()
        {
            var whitePawnMoveLimit = new MoveLimit(
                    new IncrementalMoveLimit(1), 
                    new DecrementalMoveLimit()
                );

            var whitePawnMoveset = new WhitePawnMoveset(new MoveLimit(new IncrementalMoveLimit(), new DecrementalMoveLimit());
            foreach (var symbol in SquareDesignationSymbols.rankSymbols) 
            {
                _chessPieces.Add(symbol + "7", new Pawn(ChessColor.Black));
                _chessPieces.Add(symbol + "2", new Pawn(ChessColor.White));
            }
        }
    }
}
