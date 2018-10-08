namespace Game
{
    class Hero : Unit
    {

        public Hero(string name, int x, int y) : base(name, x, y)
        {
        }

        public void MoveRight()
        {
                X++;
        }

        public void MoveLeft()
        {
            X--;
        }

        public void Render()
        {
            CursorPosition(X, Y, Name);
        }

        public int GetCursorPosition()
        {
            return X;
        }




    }
}
