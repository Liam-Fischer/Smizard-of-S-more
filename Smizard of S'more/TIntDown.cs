using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smizard_of_S_more
{
    public class TIntDown : gameBlock
    {
        public TIntDown(int _x, int _y)
        {
            walls = new List<Rectangle>();

            x = _x;
            y = _y;

            me = new Rectangle(x, y, size, size);

            leftAllowed = true;
            rightAllowed = true;
            downAllowed = true;
            upAllowed = false;

            // Define interneal walls for drawing here
            walls.Add(new Rectangle(x, y, size, 4));
        }
    }
}
