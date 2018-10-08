using Game.GameGUI;
using System.Collections.Generic;

namespace Game
{
    class GameScreen : Window
    {
        private int Width;
        private int Height;
        private Hero hero;
        List<Enemy> enemyList = new List<Enemy>();

        public GameScreen(int width, int height) : base(0, 0, width, height, '%')
        {
            Width = width;
            Height = height;
        }


        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public Hero GetHero()
        {
            return hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemyList.Add(enemy);
        }

        public void MoveAllEnemiesDown()
        {
            foreach (var item in enemyList)
            {

                item.MoveDown();
            }
        }

        public int GetEnemyPosition(int number)
        {
            foreach (var item in enemyList)
            {
                if (item.GetCursorPosition() < number)
                {
                    return item.GetCursorPosition();
                }
                return -1;
            }

            return -1;
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (var item in enemyList)
            {
                if (item.GetId() == id)
                {
                    return item;
                }
            }

            return null;
        }

        public override void Render()
        {
            base.Render();
            hero.Render();

            foreach (var item in enemyList)
            {
                item.Render();
            }
        }

    }
}
