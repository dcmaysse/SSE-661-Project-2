using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_661_Project_2
{
    class SkeleRoomMemento
    {
        private int[] walls, data;

        public SkeleRoomMemento(int[]walls, int[]data)
        {
            this.walls = walls;
            this.data = data;
        }

        public int[] wallState
        {
            get { return walls; }
        }

        public int[] dataState
        {
            get { return data; }
        }
    }
}
