using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_661_Project_2
{
    class SkeleRoomCaretaker
    {
        SkeleRoomMemento memento;

        public SkeleRoomMemento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
