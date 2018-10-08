namespace Game.GameGUI
{
    class Window : GuiObject
    {
        private Frame Border;
        public Window(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            Border = new Frame(x, y, width, height, renderChar);
        }

        public virtual void Render()
        {
            Border.Render();
        }
    }
}
