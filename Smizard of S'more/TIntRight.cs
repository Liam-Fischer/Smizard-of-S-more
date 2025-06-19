using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class TIntRight : gameBlock
    {
        public TIntRight(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            leftAllowed = false;
            rightAllowed = true;
            downAllowed = true;
            upAllowed = true;

            walls.Add(new Rectangle(x, y, 4, size));
        }
    }
}
