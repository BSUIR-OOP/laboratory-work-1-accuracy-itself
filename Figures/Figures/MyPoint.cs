using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Figures
{
    internal class MyPoint : MyShapes
    {
        public int x, y;
        public MyPoint(MyPoint point)
        {
            this.x = point.x;
            this.y = point.y;
        }
        public MyPoint(int x, int y, Brush br)
        {
            this.x = x;
            this.y = y;
            Color = br;
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
            Color = Brushes.Red;
        }

        public override void Draw(Canvas g)
        {
            MyCircle point = new MyCircle(x, y, 2, Color);
            point.Draw(g);
        }
    }
}
