using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class DAndL : gameBlock
    {
        public DAndL(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            upAllowed = false;
            rightAllowed = false;
            downAllowed = true;
            leftAllowed = true;

            me = new Rectangle(x, y, size, size);

            walls.Add(new Rectangle(x, y, size, 4));
            walls.Add(new Rectangle(x + size, y, 4, size));
        }
    }
}
