using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class gameBlock
    {
        public static int size = 100;
        public int x, y;

        public List<Rectangle> walls;

        public static Rectangle me;

        //determines the allowable directions of movement
        public bool leftAllowed, rightAllowed, upAllowed, downAllowed;

    }
}
