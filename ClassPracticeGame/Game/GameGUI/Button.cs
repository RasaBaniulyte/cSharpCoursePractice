namespace Game.GameGUI
{
    class Button : GuiObject
    {
        private Frame ActiveFrame;
        private bool IsActive = false;
        private Frame NonActiveFrame;
        private TextLine TextLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            ActiveFrame = new Frame(x, y, width, height, '#');
            NonActiveFrame = new Frame(x, y, width, height, '+');
            TextLine = new TextLine(x + 1, y + (height / 2), width - 2, buttonText);
        }

        public void Render()
        {
            if (IsActive)
            {
                ActiveFrame.Render();
            }
            else
            {
                NonActiveFrame.Render();
            }

            TextLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }

        internal void SetNotActive()
        {
            IsActive = false;
        }
    }
}
