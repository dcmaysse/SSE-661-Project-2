using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_661_Project_2
{
    class SkeleRoom
    {
        private static SkeleRoom room;
        Random random;
        private int[] walls;
        private int facing, sizeX, sizeY, x, y;

        private SkeleRoom()
        {
            random = new Random();
            walls = new int[4];
            facing = -1;
        }

        public static SkeleRoom Instance()
        {
            if (room==null)
            {
                room = new SkeleRoom();
            }

            return room;
        }

        public void generate(int sizeX, int sizeY)
        {
            facing = random.Next(0, 4);
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            x = random.Next(0, sizeX);
            y = random.Next(0, sizeY);

            for (int i = 0; i < 4; i++)
            {
                walls[i] = random.Next(0, 2);
            }
        }

        public void printDetails()
        {
            if (facing == -1)
                Console.WriteLine("Not instantiated");
            else
            {
                Console.WriteLine("Facing: " + facing);
                Console.WriteLine("Coords: " + x + "," + y);
                string wallString = "";
                for (int i = 0; i < 4; i++)
                {
                    if (walls[i] == 1)
                        wallString = wallString + " " + i;
                }
                Console.WriteLine("Walls:" + wallString+"\r\n");
            }
        }

        public SkeleRoomMemento createMemento()
        {
            int[] data = new int[] { facing, sizeX, sizeY, x, y };
            return new SkeleRoomMemento(walls, data);
        }

        public void setMemento(SkeleRoomMemento memento)
        {
            walls = memento.wallState;
            facing = memento.dataState[0];
            sizeX = memento.dataState[1];
            sizeY = memento.dataState[2];
            x = memento.dataState[3];
            y = memento.dataState[4];
        }
    }
}
