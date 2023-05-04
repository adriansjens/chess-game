using ChessGame.Game;
using ChessGame.Game.PieceLogic;
using ChessGame.GameInterface;

namespace ChessGameTest
{
    public class ConsoleChessGameInterfaceTest
    {
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void RendersCorrectly()
        {
            //Arrange
            var board = new Board(new ChessPieceFactory());
            var squares = board.PerformGameSetup();

            var gameInterface = new ConsoleChessGameInterface();

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Test
            gameInterface.RenderBoardState(squares);

            //Assert
            const string expectedOutput = "8 [♜][♞][♝][♛][♚][♝][♞][♜]\r\n7 [♟︎][♟︎][♟︎][♟︎][♟︎][♟︎][♟︎][♟︎]\r\n6 [  ][⬛][  ][⬛][  ][⬛][  ][⬛]\r\n5 [⬛][  ][⬛][  ][⬛][  ][⬛][  ]\r\n4 [  ][⬛][  ][⬛][  ][⬛][  ][⬛]\r\n3 [⬛][  ][⬛][  ][⬛][  ][⬛][  ]\r\n2 [♙][♙][♙][♙][♙][♙][♙][♙]\r\n1 [♖][♘][♗][♕][♔][♗][♘][♖]\r\n   a   b   c   d   e   f  g   h\r\n";

            var output = stringWriter.ToString();
            Assert.That(output, Is.EqualTo(expectedOutput));
        }
    }
}