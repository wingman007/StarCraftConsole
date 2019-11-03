using System;

namespace StarCraftConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit();
            Unit unit2 = new Unit();

            Time time = new Time();
            time.AttachUnit(unit1);
            time.AttachUnit(unit2);

            Space space = new Space();
            space.RegisterUnitInSpace(unit1);
            space.RegisterUnitInSpace(unit2);

            View view = new View(space);
            // view.RenderWorld(); // I will need two threads for rendering "on the plamshet" and time in the "real" world
            time.Start(view);// If I want them in one thread rendering ant time should be connected
        }
    }
}
