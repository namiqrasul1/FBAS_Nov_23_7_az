using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class HouseBuilder
    {
        private House house = new();
        public HouseBuilder BuildWalls(int count)
        {
            house.Walls = count;
            return this;
        }
        public HouseBuilder BuildRooms(int count)
        {
            house.Rooms = count;
            return this;
        }
        public HouseBuilder BuildDoors(int count)
        {
            house.Doors = count;
            return this;
        }
        public HouseBuilder BuildWindows(int count)
        {
            house.Windows = count;
            return this;
        }
        public HouseBuilder BuildGarrage()
        {
            house.HasGarrage = true;
            return this;
        }
        public HouseBuilder BuildRoof()
        {
            house.HasRoof = true;
            return this;
        }
        public HouseBuilder BuildGarden()
        {
            house.HasGarden = true;
            return this;
        }
        public HouseBuilder BuildPool()
        {
            house.HasPool = true;
            return this;
        }
        public void Reset()
        {
            house = new House();

        }

        public House GetHouse()
        {
            return house;
        }
    }
}
