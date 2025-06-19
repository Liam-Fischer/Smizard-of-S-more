using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class DAndR : gameBlock
    {
        public DAndR(int _x, int _y)
        {
            walls = new List<Rectangle>();
            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            upAllowed = false;
            rightAllowed = true;
            downAllowed = true;
            leftAllowed = false;

            walls.Add(new Rectangle(x, y - 4, size, 4));
            walls.Add(new Rectangle(x , y, 4, size));
        }
    }
}
