using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellSimulator.Model
{
    class RectData
    {
        public int X=0;
        public int Y=0;
        public int Width=50;
        public int Height=50;
        public Color ColorRect = Color.DarkCyan;


        public RectData(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
