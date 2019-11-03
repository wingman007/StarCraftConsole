namespace StarCraftConsole
{
    public class Space
    {
        // public Unit[] UitsInAPointOfSpace { get; set; }
        public Unit[,,] CartazianCoordinates { get; set; }

        public Space(int maxXInTheSpace = 80, int maxYInTheSpace = 30)
        {
            CartazianCoordinates = new Unit[maxXInTheSpace, maxYInTheSpace, 600];
        }

        public void RegisterUnitInSpace(Unit unit) 
        {
            int i = 0;
            for (i = 0; i < 600; i++) // no more than 200 units in one point of space
            {
                if (CartazianCoordinates[unit.PositionX, unit.PositionY, i] == null) break;
            }
            CartazianCoordinates[unit.PositionX, unit.PositionY, i] = unit; 
        }

        public void UnRegisterUnitInSpace(Unit unit)
        {
            int i = 0;
            for (i = 0; i < 600; i++) // no more than 200 units in one point of space
            {
                if (CartazianCoordinates[unit.PositionX, unit.PositionY, i] == unit) break;
            }
            CartazianCoordinates[unit.PositionX, unit.PositionY, i] = null;
        }
    }
}