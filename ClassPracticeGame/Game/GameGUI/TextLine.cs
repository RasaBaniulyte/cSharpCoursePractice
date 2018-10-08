using System;

namespace Game.GameGUI
{
    class TextLine : GuiObject
    {
        private string Data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 1)
        {
            Data = data;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > Data.Length)
            {
                int offset = (Width - Data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(Data);
        }


    }
}
