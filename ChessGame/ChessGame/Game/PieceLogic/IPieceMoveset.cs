namespace ChessGame.Game.PieceLogic
{
    public interface IPieceMoveset
    {
        public Dictionary<string, int> IncrementalMoveLimits { get; }
        public Dictionary<string, int> DecrementalMoveLimits { get; }
    }
}
