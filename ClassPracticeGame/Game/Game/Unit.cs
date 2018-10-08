using System;

namespace Game
{
    class Unit
    {
        protected string Name;
        protected int X;
        protected int Y;

        public Unit(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {Name} position is {X} : {Y}");
        }

        public void CursorPosition(int x, int y, string name)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(name);
            Console.CursorVisible = false;
        }
    }
}
