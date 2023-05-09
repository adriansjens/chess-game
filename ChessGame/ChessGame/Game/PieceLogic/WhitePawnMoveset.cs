namespace ChessGame.Game.PieceLogic
{
    public class WhitePawnMoveset : IPieceMoveset
    {
        public MoveLimit VerticalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(1, 1), new DecrementalMoveLimit(0, 0));

        public MoveLimit HorizontalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(0, 0));

        public MoveLimit DiagonalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(0, 0));

        public int TotalUpperMoveLimit { get; } = 1;

        public int TotalLowerMoveLimit { get; } = 1;

        public bool CapturesDiagonally { get; } = true;
    }
}
