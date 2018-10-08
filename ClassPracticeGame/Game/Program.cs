using Game.GameGUI;
using Game.View;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game newGame = new Game();
            //newGame.StartGame();

            Console.CursorVisible = false;


            //GameController gameController = new GameController();
            //
            //gameController.ShowMenu();

            new GameOverWindow();

            Console.ReadKey();

        }
    }
}
