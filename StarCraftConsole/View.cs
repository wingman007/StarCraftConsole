using System;
using System.Collections.Generic;
using System.Text;

namespace StarCraftConsole
{
    public class View // This is the planshed we use to represent the world in the HQ. We can represent every unit differently. In this case we use the console. We can use GUI etc.
    {
        public Space Space { get; set; }

        public View(Space space)
        {
            Space = space;
        }
        public void RenderWorld()
        {
            //while (true) // the endless loop is in Time. Just to use one thread
            //{
                Console.Clear();
                // System.Threading.Thread.Sleep(80); // 1000 / 12 = 83.333 times per second is what we need for motion picture // I am using the timing in the real world. if you want to separate them use another thread
                RenderUnits();
            //}


        }
        public void RenderUnits()
        {
            Unit unit;
            for (int i = 0; i < Space.CartazianCoordinates.GetLength(0); i++)
            {
                for (int j = 0; j < Space.CartazianCoordinates.GetLength(1); j++)
                {
                    for (int n = 0; n < 600; n++)
                    {
                        unit = Space.CartazianCoordinates[i, j, n];
                        if (unit == null) continue;
                        RenderIndividualunit(unit);
                    }
                }
            }
        }

        public void RenderIndividualunit(Unit unit)
        {
            Console.SetCursorPosition((unit.PositionX < 80)? unit.PositionX : 80, (unit.PositionY < 30)? unit.PositionY : 30);
            Console.ForegroundColor = (ConsoleColor)unit.Color;
            Console.Write(unit.Avatar);
        }
    }
}
