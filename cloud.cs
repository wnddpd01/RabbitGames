using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sosil3_homework
{
    class cloud
    {
        public Point location;
     
        public cloud(Point loc)
        {
            location = loc;
        }

        public Point move(bool dir,int score)
        {
            int move_range = 3;
            if (score / 100 < 10)
                move_range = score / 100 + 3;
            else
                move_range = 15;
            if (dir == false)
                move_range = move_range * -1;

            location.X += move_range;
            return location;
        }
    }
}
