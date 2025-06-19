using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class LeftNRight : gameBlock
    {
        public LeftNRight(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            upAllowed = false;
            downAllowed = false;
            leftAllowed = true;
            rightAllowed = true;

            walls.Add(new Rectangle(x, y, size, 4));
            walls.Add(new Rectangle(x - 4, y + size, size, 4));
        }

    }
}
