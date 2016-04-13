using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Abstract
{
    public abstract class Graph
    {
        public int xPos;
        public int yPos;
        public int width;
        public int height;

        public abstract void SetSource(double row1, double col1, double row2, double col2, string graphBy = "");
    }
}
