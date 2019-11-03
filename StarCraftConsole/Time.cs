using System;

namespace StarCraftConsole
{
    public class Time
    {
        public Random RandomGenerator { get; set; }
        public Unit[] units { get; set; }

        public void Start(View view)
        {
            while (true)
            {
                Tick();
                view.RenderWorld();
            }
        }
        public void Tick(int period = 100)
        {
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i] == null) continue;
                // units[i].Move(1, 1); // this should be a callback
                units[i].Move(RandomGenerator.Next(-10,10), RandomGenerator.Next(-10, 10));
            }
            System.Threading.Thread.Sleep(period);
        }

        public Time()
        {
            units = new Unit[600];
            RandomGenerator = new Random();
        }
        public void AttachUnit(Unit unit)
        {
            int i = 0;
            for (i = 0; i < units.Length; i++)
            {
                if (units[i] == null) break;
            }
            units[i] = unit;
        }
    }
}