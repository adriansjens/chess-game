using ChessGame.Game;
using ChessGame.Game.Constants;
using ChessGame.Game.PieceLogic;

namespace ChessGame.GameInterface
{
    public class ConsoleChessGameInterface : IChessGameInterface
    {
        public void RenderMenu()
        {
            Console.WriteLine("Welcome to Amazing Chess " +
                "\nWould you like to: " +
                "\n1: Start a new game" +
                "\n2: Exit");
        }

        public string GetMenuChoiceFromUser()
        {
            var userMenuChoice = "";

            var menuChoiceObtained = false;
            while (!menuChoiceObtained)
            {
                userMenuChoice = Console.ReadLine();
                if (userMenuChoice != MenuOptions.NewGame && userMenuChoice != MenuOptions.Exit)
                {
                    Console.WriteLine($"{userMenuChoice} is not an accepted answer. Please try again");
                    continue;
                }

                menuChoiceObtained = true;
            }

            return userMenuChoice ?? "";
        }

        public void RenderBoardState(List<Square> squares)
        {
            foreach (var rankSymbol in SquareDesignationSymbols.rankSymbols.Reverse())
            {
                var rowToPrint = BuildPrintableRow(squares, rankSymbol);

                Console.WriteLine(string.Concat(rowToPrint));
            }

            PrintFinalRow();
        }

        public void Exit() 
        {
            Console.WriteLine("Bye!");
        }

        public bool MakeMove()
        {
            throw new NotImplementedException();
        }

        private List<string> BuildPrintableRow(List<Square> squares, string rankSymbol)
        {
            var rowToPrint = new List<string>() { rankSymbol + " " };
            foreach (var fileSymbol in SquareDesignationSymbols.fileSymbols)
            {
                var squareToAdd = squares.FirstOrDefault(square => square.Designation == fileSymbol + rankSymbol) ??
                    throw new Exception("error encountered during board state render");

                var squareStringRepresentation = squareToAdd.Color == ChessColor.White ? "[\u2004 ]" : "[\u2B1B]";
                if (squareToAdd.CurrentPiece != null) squareStringRepresentation = $"[{squareToAdd.CurrentPiece.UnicodeCharacter}]";

                rowToPrint.Add(squareStringRepresentation);
            }

            return rowToPrint;
        }

        private void PrintFinalRow()
        {
            Console.WriteLine("   a   b   c   d   e   f  g   h");
        }
    }
}
