using Game.GameGUI;
using System.Collections.Generic;

namespace Game.View
{
    class GameOverWindow : Window
    {
        private TextBlock TitleTextBlock;
        private List<Button> Buttons = new List<Button>();
        private int CurrentSelection = 0;

        public GameOverWindow() : base(28, 5, 60, 18, '@')
        {
            TitleTextBlock = new TextBlock(30, 10, 58, new List<string> { "GAME OVER" });

            Buttons.Add(new Button(35, 15, 15, 3, "Restart"));

            Buttons.Add(new Button(65, 15, 15, 3, "Menu"));

            ActivateCurrentButtonSelected();

            Render();
        }

        public override void Render()
        {
            base.Render();
            TitleTextBlock.Render();

            foreach (var item in Buttons)
            {
                item.Render();
            }
        }

        public void SelectNextMenuItem()
        {
            if (CurrentSelection < Buttons.Count - 1)
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
            }
        }

        private void ActivateCurrentButtonSelected()
        {
            for (int i = 0; i < Buttons.Count; i++)
            {
                Button btn = Buttons[i];

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

        internal int GetCurrentSelected()
        {
            return CurrentSelection;
        }

    }
}
