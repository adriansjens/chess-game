namespace ChessGame.Game.PieceLogic
{
    public class KnightMoveset : IPieceMoveset
    {
        public MoveLimit VerticalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(2, 1), new DecrementalMoveLimit(2, 1));

        public MoveLimit HorizontalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(2, 1), new DecrementalMoveLimit(2, 1));

        public MoveLimit DiagonalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(0, 0));

        public int TotalUpperMoveLimit { get; } = 3;

        public int TotalLowerMoveLimit { get; } = 3;
    }
}
