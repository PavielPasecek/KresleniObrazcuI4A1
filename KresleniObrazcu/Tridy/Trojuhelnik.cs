using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KresleniObrazcu.Tridy
{
    public class Trojuhelnik : Obrazec
    {
        public override void Vykresli(Canvas platno)
        {
            Polygon trojuhelnik = new Polygon
            {
                Points = new PointCollection()
                {
                    new Point(Width/2, 0),
                    new Point(0, Height),
                    new Point(Width, Height)
                },

                Stroke = Brushes.Black,
                StrokeThickness = TloustkaCary,
                Fill = Vypln
            };

            Canvas.SetLeft(trojuhelnik, X);
            Canvas.SetTop(trojuhelnik, Y);

            platno.Children.Add(trojuhelnik);
        }

        public Trojuhelnik(double x, double y, double tl, Brush vypl) : base(x, y, tl, vypl)
        {

        }
    }
}
