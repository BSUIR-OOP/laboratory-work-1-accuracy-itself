using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Figures
{
    /// <summary>
    /// 
    /// Логика взаимодействия для MainWindow.xaml
    ///
    /// </summary>
    /// 

    //по идее этот класс и работает как список, ведь у него есть метод add, с помощью которого туда добавляются объекты
    public class ListShapes 
    {
        public List<MyShapes> list;
        public void DrawList(Canvas g)
        {
            foreach(MyShapes shape in list)
            {
                shape.Draw(g);
            }
        }

        public ListShapes()
        { list = new List<MyShapes>(); }

        public void Add(MyShapes shape)
        {
            list.Add(shape);
        }
       
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //и пока что никаких нигде проверок на корректность данных(длина больше ноля и прочее)
        private void bPaint_Click(object sender, RoutedEventArgs e)
        {
            int modrandOrd = 900, modrandMin = 150;
            Random random = new Random();
            ListShapes listShapes = new ListShapes();
            /*MyRectangle rect = new MyRectangle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandMin, Brushes.DarkBlue);
            listShapes.Add(rect); random.Next();
            MyRectangle rect2 = new MyRectangle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.Crimson);
            listShapes.Add(rect2); random.Next();
            MySegment segm1 = new MySegment(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.GreenYellow);
            listShapes.Add(segm1); 
            MyEllipse ell1 = new MyEllipse(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandMin, random.Next() % modrandMin, Brushes.Bisque);
            listShapes.Add(ell1); random.Next();
            listShapes.Add(new MyCircle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandMin, Brushes.AliceBlue));
            MyTriangle triangle = new MyTriangle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.Gold);
            listShapes.Add(triangle);
            MyPoint point = new MyPoint(random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.DarkGreen);
            listShapes.Add(point);
            */
            MyRectangle rect = new MyRectangle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandMin, Brushes.Red);
            listShapes.Add(rect); random.Next();
            MyRectangle rect2 = new MyRectangle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.Orange);
            listShapes.Add(rect2); random.Next();
            MySegment segm1 = new MySegment(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.Yellow);
            listShapes.Add(segm1);
            MyEllipse ell1 = new MyEllipse(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandMin, random.Next() % modrandMin, Brushes.Green);
            listShapes.Add(ell1); random.Next();
            listShapes.Add(new MyCircle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandMin, Brushes.LightBlue));
            MyTriangle triangle = new MyTriangle(random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.Violet);
            listShapes.Add(triangle);
            MyPoint point = new MyPoint(random.Next() % modrandOrd, random.Next() % modrandOrd, Brushes.Violet);
            listShapes.Add(point);

            listShapes.DrawList(g);
        }
    }
}
