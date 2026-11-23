using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace KresleniObrazcu.Tridy
{
    public abstract class Obrazec
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double TloustkaCary { get; set; }
        public Brush Vypln { get; set; }

        public abstract void Vykresli(Canvas platno);

        public Obrazec(double x, double y, double tl, Brush vypl)
        {
            X = x;
            Y = y;
            TloustkaCary = tl;
            Vypln = vypl;
        }
        public void NastavSirku(double w, double h)
        {
            Width = w; 
            Height = h;
        }
    }
}
