namespace Game
{
    class Enemy : Unit
    {
        private int Id;

        public Enemy(int id, string name, int x, int y) : base(name, x, y)
        {
            Id = id;
        }

        public void MoveDown()
        {
            Y++;
        }

        public int GetId()
        {
            return Id;
        }

        public void Render()
        {
            CursorPosition(X, Y, Name);
        }

        public int GetCursorPosition()
        {
            return Y;
        }
    }
}
