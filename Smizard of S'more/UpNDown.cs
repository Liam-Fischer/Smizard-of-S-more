﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class UpNDown : gameBlock
    {
        public UpNDown(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            leftAllowed = false;
            rightAllowed = false;
            downAllowed = true;
            upAllowed = true;

            walls.Add(new Rectangle(x, y, 4, size));
            walls.Add(new Rectangle(x + size - 4, y, 4, size));
        }
    }
}
