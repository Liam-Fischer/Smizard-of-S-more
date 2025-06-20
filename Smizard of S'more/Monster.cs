using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    internal class Monster
    {
        public int x;
        public int y;
        int homeX, homeY;
        int width = 36;
        int height = 32;
        int speed = gameBlock.size;

        bool visible = true;
        

        public Rectangle monBox;

        public Monster()
        {
            //builds the monster
            homeX  = 910 + width;
            homeY  = gameBlock.size - (3 * height / 2);

            x = homeX;
            y = homeY;

            monBox = new Rectangle(x, y, width, height);
        }

        public void Move(string direction)
        {
            //moves the monster
            if (direction == "right")
            {
                x += speed;
            }
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }

            monBox = new Rectangle(x, y, width, height);
        }
    }
}
