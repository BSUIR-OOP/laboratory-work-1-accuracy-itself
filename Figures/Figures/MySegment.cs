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
    internal class MySegment : MyShapes
    {
        MyPoint v1, v2;
        public override void Draw(Canvas g)
        {
            Line L;
            L = new Line();
            L.X1 = v1.x; L.Y1 = v1.y;
            L.X2 = v2.x; L.Y2 = v2.y;
            L.Stroke = Color;
            L.StrokeThickness = 3;
            g.Children.Add(L);
        }

        public MySegment(int x1, int y1, int x2, int y2, Brush br)
        {
            v1 = new MyPoint(x1, y1);
            v2 = new MyPoint(x2, y2);
            Color = br;
        }
    }
}
