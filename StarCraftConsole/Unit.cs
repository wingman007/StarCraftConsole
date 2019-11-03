using System;
using System.Collections.Generic;
using System.Text;

namespace StarCraftConsole
{
    public class Unit
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public int Stamina { get; set; }

        public int DamageToEnemy { get; set; }

        public string Avatar { get; set; }

        public int Color { get; set; }

        public Random RandomGenerator { get; set; }

        public Unit(string avatar = "@")
        {
            RandomGenerator = new Random();
            PositionX = 0;
            PositionY = 0;
            Stamina = 100;
            DamageToEnemy = 1;
            Avatar = Stamina.ToString();
            Color = RandomGenerator.Next(0, 15);
        }

        public void AttachToSpace(Space space)
        {
            space.RegisterUnitInSpace(this);
        }
        public void AttachToTime(Time time)
        {

        }

        //public void Move(int directionX, int directionY)
        //{
        //    PositionX += directionX;
        //    PositionY += directionY;
        //}

        public void Move(int directionX, int directionY)
        {
            if (directionX >= 0)
            {
                if (PositionX < 80) PositionX += 1;
            }
            else
            {
               if (PositionX > 0) PositionX -= 1;
            }
            if (directionY >= 0)
            {
                if (PositionY < 30) PositionY += 1;
            }
            else
            {
                if (PositionY > 0) PositionY -= 1;
            }
            
        }

        public void Attack(Unit enemy)
        {
            enemy.Stamina -= this.DamageToEnemy;
        }

        //public void Render()
        //{

        //}
    }
}
