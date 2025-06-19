using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    internal class Player
    {
        public int x;
        public int y;
        public int startX;
        public int startY;
        public int speed = gameBlock.size;
        public static int width = 40;
        public static int height = 45;
        public int cooldown = 700;
        int border = 20;

        public Player()
        {
            startX = border + (gameBlock.size / 2) - (width/2);
            startY = Gamescreen.playScreenY - gameBlock.size + (gameBlock.size / 2) - ((height -1)/4);

            x = startX;
            y = startY;
        }

        public void Move(string direction)
        {
            if (direction == "right" && (x + gameBlock.size) < Gamescreen.playScreenX - width)
            {
               x += speed;
            }
            if (direction == "left" && (x - gameBlock.size) > border - width)
            {
                x -= speed;
            }
            if (direction == "up" && (y - gameBlock.size) > border - height)
            {
                y -= speed;
            }
            if (direction == "down" && (y + gameBlock.size) < Gamescreen.playScreenY - height)
            {
                y += speed;
            }
        }
    }
}
