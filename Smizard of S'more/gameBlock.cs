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

        public bool leftAllowed, rightAllowed, upAllowed, downAllowed;

        //public gameBlock(int _x, int _y)
        //{
        //    x = _x;
        //    y = _y;


        //    moveType[0] = "l&R";
        //    moveType[1] = "fourWay";
        //    moveType[2] = "tIntDwn";
        //    moveType[3] = "elbowDR";
        //    moveType[5] = "u&D";
        //    moveType[6] = "elbowUR";
        //    moveType[7] = "elbowDL";
        //    moveType[8] = "elbowUL";
        //    moveType[9] = "tIntUp";
        //    moveType[10] = "tIntLft";
        //    moveType[11] = "tIntRt";
        //}
    }
}
