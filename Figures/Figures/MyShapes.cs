using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Figures
{
    public abstract class MyShapes
    {
        public Brush Color;
        public abstract void Draw(Canvas g);
    }
}
