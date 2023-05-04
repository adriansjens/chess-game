using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Game.PieceLogic
{
    public class PawnMoveset : IPieceMoveset
    {
        public int UpperHorizontalMoveLimit { get; } = 0;
        public int LowerHorizontalMoveLimit { get; } = 0;
        public int UpperVerticalMoveLimit { get; } = 1;
        public int LowerVerticalMoveLimit { get; }
        public int UpperDiagonalMoveLimit { get; }
        public int LowerDiagonalMoveLimit { get; }
    }
}
