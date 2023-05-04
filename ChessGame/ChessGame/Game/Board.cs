﻿using ChessGame.Game.Constants;
using ChessGame.Game.PieceLogic;

namespace ChessGame.Game
{
    public class Board
    {
        private readonly ChessPieceFactory _factory;
        private readonly List<Square> _squares = new();

        public Board(ChessPieceFactory factory) 
        {
            _factory = factory;
        }

        public List<Square> PerformGameSetup()
        {
            var squareDesignations = GetSquareDesignations();
            AddSquares(squareDesignations);

            return GetBoardState();
        }

        public List<Square> GetBoardState()
        {
            return _squares;
        }

        private void AddSquares(List<string> squareDesignations)
        {
            var nextSquareColor = ChessColor.Black;
            foreach (var designation in squareDesignations)
            {
                var defaultPiece = _factory.GetChessPieceForSquare(designation);
                var square = new Square(designation, nextSquareColor, defaultPiece);

                _squares.Add(square);

                var endOfFile = designation.EndsWith(SquareDesignationSymbols.rankSymbols.Last());
                if (!endOfFile) nextSquareColor = ChessColor.ChangeColor(nextSquareColor);
            }
        }

        private List<string> GetSquareDesignations()
        {
            var squareDesignations = new List<string>();
            foreach (var fileSymbol in SquareDesignationSymbols.fileSymbols)
            
                foreach (var rankSymbol in SquareDesignationSymbols.rankSymbols) 
                    squareDesignations.Add(fileSymbol + rankSymbol);

            return squareDesignations;
        }
    }
}
