namespace ChessGame.Game.PieceLogic
{
    public static class ChessColor
    {
        public const string White = "White";
        public const string Black = "Black";

        public static string ChangeColor(string color)
        {
            if (color == White) return Black;
            if (color == Black) return White;

            return color;
        }
    }
}
