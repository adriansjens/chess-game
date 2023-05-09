namespace ChessGame.Game.PieceLogic
{
    public interface IPieceMoveset
    {
        public MoveLimit VerticalMoveLimit { get; }
        public MoveLimit HorizontalMoveLimit { get; }
        public MoveLimit DiagonalMoveLimit { get; }
        public int TotalUpperMoveLimit { get; }
        public int TotalLowerMoveLimit { get; }
        public bool CapturesDiagonally { get; }
    }

    public class MoveLimit
    {
        public IncrementalMoveLimit IncrementalMoveLimit { get; }
        public DecrementalMoveLimit DecrementalMoveLimit { get; }

        public MoveLimit(IncrementalMoveLimit incrementalMoveLimit, DecrementalMoveLimit decrementalMoveLimit) 
        { 
            IncrementalMoveLimit = incrementalMoveLimit;
            DecrementalMoveLimit = decrementalMoveLimit;
        }
    }

    public class IncrementalMoveLimit
    {
        public int UpperMoveLimit { get; }
        public int LowerMoveLimit { get; }

        public IncrementalMoveLimit(int upperMoveLimit, int lowerMoveLimit)
        {
            UpperMoveLimit = upperMoveLimit;
            LowerMoveLimit = lowerMoveLimit;
        }
    }

    public class DecrementalMoveLimit
    {
        public int UpperMoveLimit { get; }
        public int LowerMoveLimit { get; }

        public DecrementalMoveLimit(int upperMoveLimit, int lowerMoveLimit)
        {
            UpperMoveLimit = upperMoveLimit;
            LowerMoveLimit = lowerMoveLimit;
        }
    }
}
