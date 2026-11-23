using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KresleniObrazcu.Tridy
{
    public class Kruh : Obrazec
    {
        public override void Vykresli(Canvas platno)
        {
            Ellipse elipsa = new Ellipse();

            elipsa.Width = 80;
            elipsa.Height = 80;

            elipsa.Stroke = Brushes.Black;
            elipsa.StrokeThickness = TloustkaCary;
            elipsa.Fill = Vypln;

            Canvas.SetLeft(elipsa, X);
            Canvas.SetTop(elipsa, Y);

            platno.Children.Add(elipsa);
        }
        public Kruh(double x, double y, double tl, Brush vypl) : base(x, y, tl, vypl)
        {

        }
    }
}
