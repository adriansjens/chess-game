namespace ChessGame.Game.PieceLogic
{
    public class BlackPawnMoveset : IPieceMoveset
    {
        public MoveLimit VerticalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(1, 1));

        public MoveLimit HorizontalMoveLimit { get; } = new MoveLimit(new IncrementalMoveLimit(0, 0), new DecrementalMoveLimit(0, 0));
    }
}
