using System;
using System.Collections.Generic;

namespace Game.GameGUI
{
    class GameWindow : Window
    {
        private TextBlock TitleTextBlock;

        private List<Button> allButtons = new List<Button>();

        private int CurrentSelection = 0;


        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            TitleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Rasos kuryba!", "Made in Vilnius Coding School!" });

            allButtons.Add(new Button(20, 13, 18, 5, "Start"));


            allButtons.Add(new Button(50, 13, 18, 5, "Credits"));

            allButtons.Add(new Button(80, 13, 18, 5, "Quit"));

            ActivateCurrentButtonSelected();

        }

        public void SelectNextMenuItem()
        {
            if (CurrentSelection < allButtons.Count - 1)
            {
                CurrentSelection++;
                ActivateCurrentButtonSelected();
            }
        }

        public void SelectPrevMenuItem()
        {
            if (CurrentSelection > 0)
            {
                CurrentSelection--;

                ActivateCurrentButtonSelected();
                //pereit per visus mygtukus, aktyvuot current, isjunkt kitus
            }
        }

        private void ActivateCurrentButtonSelected()
        {
            for (int i = 0; i < allButtons.Count; i++)
            {
                Button btn = allButtons[i];

                if (i == CurrentSelection)
                {
                    btn.SetActive();
                }
                else
                {
                    btn.SetNotActive();
                }


            }
        }


        public override void Render()
        {
            base.Render();

            TitleTextBlock.Render();

            foreach (var item in allButtons)
            {
                item.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        internal int GetCurrentSelected()
        {
            return CurrentSelection;
        }
    }
}
