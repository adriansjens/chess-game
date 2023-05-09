namespace ChessGame.Game.PieceLogic
{
    public class BishopMoveset : IPieceMoveset
    {
        public MoveLimit VerticalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(0, 0));

        public MoveLimit HorizontalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(0, 0));

        public MoveLimit DiagonalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(7, 1), new DecrementalMoveLimit(7, 1));

        public int TotalUpperMoveLimit { get; } = 7;

        public int TotalLowerMoveLimit { get; } = 1;
    }
}
