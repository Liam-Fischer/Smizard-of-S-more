using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class TIntUp : gameBlock
    {
        public TIntUp(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            leftAllowed = true;
            rightAllowed = true;
            downAllowed = false;
            upAllowed = true;

            walls.Add(new Rectangle(x - 4, y + size, size, 4));
        }

    }
}
