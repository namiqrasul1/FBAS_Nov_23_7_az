using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class House
    {
        //public House(int walls, int rooms, int doors, int windows, bool hasGarrage, bool hasRoof, bool hasGarden, bool hasPool)
        //{
        //    Walls = walls;
        //    Rooms = rooms;
        //    Doors = doors;
        //    Windows = windows;
        //    HasGarrage = hasGarrage;
        //    HasRoof = hasRoof;
        //    HasGarden = hasGarden;
        //    HasPool = hasPool;
        //}

        public int Walls { get; set; }
        public int Rooms { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public bool HasGarrage { get; set; }
        public bool HasRoof { get; set; }
        public bool HasGarden { get; set; }
        public bool HasPool { get; set; }

    }
}
