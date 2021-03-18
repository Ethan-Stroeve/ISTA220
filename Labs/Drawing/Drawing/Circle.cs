using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Drawing
{
    class Circle : DrawingShape, IDraw, IColor
    {
        //private int diameter;
        //private int locX = 0, locY = 0;
        //private Ellipse circle = null;

        public Circle(int diameter) :base(diameter)
        {
           // diameter = d;
        }

        //void IDraw.SetLocation(int xCoord, int yCoord)
        //{
        //    locX = xCoord;
        //    locY = yCoord;
        //}

        //void IDraw.Draw(Canvas canvas)
        //{
        //    if (circle != null)
        //    {
        //        canvas.Children.Remove(circle);
        //    }
        //    else
        //    {
        //        circle = new Ellipse();
        //    }

        //    circle.Height = diameter;
        //    circle.Width = diameter;
        //    Canvas.SetTop(circle, locY);
        //    Canvas.SetLeft(circle, locX);
        //    canvas.Children.Add(circle);
        //}

        //void IColor.SetColor(Color color)
        //{
        //    if (circle != null)
        //    {
        //        SolidColorBrush brush = new SolidColorBrush(color);
        //        circle.Fill = brush;
        //    }
        //}

        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Ellipse();
            }

            base.Draw(canvas);
        }

        //public void SetColor(Color color)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
