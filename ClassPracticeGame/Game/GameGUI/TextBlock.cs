using System.Collections.Generic;

namespace Game.GameGUI
{
    class TextBlock : GuiObject
    {
        private List<TextLine> TextBlocks = new List<TextLine>();

        public TextBlock(int x, int y, int width, List<string> textLineData) : base(x, y, width, textLineData.Count)
        {
            for (int i = 0; i < textLineData.Count; i++)
            {
                TextBlocks.Add(new TextLine(x, y + i, width, textLineData[i]));
            }
        }

        public void Render()
        {
            for (int i = 0; i < TextBlocks.Count; i++)
            {
                TextBlocks[i].Render();
            }
        }
    }
}
