using System;
using System.Collections.Generic;

namespace Game.GameGUI
{
    class CreditWindow : Window
    {
        private Button BackButton;
        private TextBlock CreditTextBlock;

        public CreditWindow() : base(28, 10, 60, 18, '@')
        {
            List<string> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Rasa Baniulyte");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Rasa Baniulyte");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Rasa Baniulyte");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Rasa Baniulyte");
            creditData.Add("");

            CreditTextBlock = new TextBlock(28 + 1, 10 +1 , 60 -1, creditData);

            BackButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            BackButton.SetActive();

        }

        public override void Render()
        {
            ConsoleKeyInfo keyPressed;
            bool DontQuit = true;

            base.Render();
            CreditTextBlock.Render();
            BackButton.Render();

            Console.SetCursorPosition(0, 0);

            do
            {

                keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.Enter:
                        DontQuit = false;
                        break;
                    case ConsoleKey.Escape:
                        DontQuit = false;
                        break;
                }

            } while (DontQuit);

        }
    }
}
