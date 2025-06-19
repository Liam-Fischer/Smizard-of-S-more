using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class UAndR : gameBlock
    {
        public UAndR(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            upAllowed = true;
            rightAllowed = true;
            downAllowed = false;
            leftAllowed = false;

            walls.Add(new Rectangle(x, y + size - 4, size, 4));
            walls.Add(new Rectangle(x, y, 4, size));
        }
    }
}
