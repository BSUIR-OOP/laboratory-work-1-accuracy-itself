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
    internal class MyRectangle : MyShapes
    {
        MyPoint center;
        public int width, height;

        public override void Draw(Canvas g) 
        {
            Rectangle rectangle; 
            rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new System.Windows.Thickness(center.x - width / 2, center.x - height / 2, 0, 0);
            rectangle.Stroke = Color;
            rectangle.StrokeThickness = 5;
            g.Children.Add(rectangle); 
        }

        /*public MyRectangle(MyPoint point, int width, int height, Brush br)
        {
            this.center = point;
            this.width = width;
            this.height = height;
            this.Color = br;
        }*/

        public MyRectangle(int x, int y, int width, int height, Brush br)
        {
            center = new MyPoint(x, y);
            this.width = width;
            this.height = height;
            Color= br;
        }

    }
}
