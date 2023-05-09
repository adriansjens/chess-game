namespace ChessGame.Game.PieceLogic
{
    public class RookMoveset : IPieceMoveset
    {
        public MoveLimit VerticalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(7, 1), new DecrementalMoveLimit(7, 1));

        public MoveLimit HorizontalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(7, 1), new DecrementalMoveLimit(7, 1));

        public MoveLimit DiagonalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(7, 1), new DecrementalMoveLimit(7, 1));

        public int TotalUpperMoveLimit { get; } = 7;

        public int TotalLowerMoveLimit { get; } = 3;
    }
}
