using Game.GameGUI;
using System;

namespace Game
{
    class GameController
    {

        private GameWindow gameWindow = new GameWindow();
        private CreditWindow creditWindow = new CreditWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyPressed;
            bool needToQuit = false;

            do
            {

                gameWindow.Render();

                keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.RightArrow:
                        gameWindow.SelectNextMenuItem();
                        break;
                    case ConsoleKey.LeftArrow:
                        gameWindow.SelectPrevMenuItem();
                        break;
                    case ConsoleKey.Enter:
                        switch (gameWindow.GetCurrentSelected())
                        {
                            case 0:
                                StartGame();
                                break;
                            case 1:
                                creditWindow.Render();
                                break;
                            case 2:
                                needToQuit = true;
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        needToQuit = true;
                        break;

                }

            } while (needToQuit == false);
        }



        private void StartGame()
        {
            GameScreen myGame = new GameScreen(120, 30);


            myGame.SetHero(new Hero("@", 60, 25));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(i, "$", rnd.Next(0, 110), rnd.Next(0, 3)));
                enemyCount++;
            }


            /*for (int i = 1; i < 11; i++)
            {
                myGame.AddEnemy(new Enemy(i, "$" + i, (i * 20) + 1, 10));

            }*/

            bool NeedToRender = true;
            int Count = 0;

            do
            {
                Console.Clear();


                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            NeedToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            if (myGame.GetHero().GetCursorPosition() < 118)
                            {
                                myGame.GetHero().MoveRight();
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (myGame.GetHero().GetCursorPosition() > 1)
                            {
                                myGame.GetHero().MoveLeft();
                            }
                            break;

                    }
                }

                Count++;



                if (Count == 1)
                {
                    if (myGame.GetEnemyPosition(28) != -1)
                    {
                        myGame.MoveAllEnemiesDown();
                    }
                    else
                    {
                        NeedToRender = false;
                    }
                    Count = 0;
                }

                myGame.Render();

                System.Threading.Thread.Sleep(250);

            } while (NeedToRender);



        }

    }
}

