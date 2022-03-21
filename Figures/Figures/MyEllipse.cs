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
    internal class MyEllipse : MyShapes
    {
        protected MyPoint a;
        int width;
        int height;

        public override void Draw(Canvas g)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = width;
            ellipse.Height = height;
            ellipse.Margin = new System.Windows.Thickness(a.x, a.y, 0, 0);
            ellipse.Stroke = Color;
            ellipse.StrokeThickness = 2;
            g.Children.Add(ellipse);
        }

        public MyEllipse(int x, int y, int width, int height, Brush br)
        {
            a = new MyPoint(x, y);
            this.width = width;
            this.height = height;
            Color = br;
        }
    }
}
