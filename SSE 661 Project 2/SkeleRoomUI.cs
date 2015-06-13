using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_661_Project_2
{
    class SkeleRoomUI
    {
        public static void Main(string[] args)
        {
            SkeleRoom room1 = SkeleRoom.Instance();
            room1.generate(10, 10);
            SkeleRoom room2 = SkeleRoom.Instance();

            SkeleRoomCaretaker caretaker = new SkeleRoomCaretaker();
            caretaker.Memento = room1.createMemento();

            print(room1, room2);

            room1.generate(4, 4);

            Console.WriteLine("Room regenerated.");
            print(room1, room2);

            Console.WriteLine("Room restored.");
            room2.setMemento(caretaker.Memento);
            print(room1, room2);
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void print(SkeleRoom room1, SkeleRoom room2)
        {
            Console.WriteLine("Room 1:");
            room1.printDetails();
            Console.WriteLine("Room 2:");
            room2.printDetails();
        }
    }
}
