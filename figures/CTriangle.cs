using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4.figures
{
    public class CTriangle : IShape
    {
        public Size shapeSize { get; set; }
        public Point p0 { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Point[] points = {new Point(p0.X + shapeSize.Width / 2 , p0.Y) , new Point(p0.X, p0.Y + shapeSize.Height), new Point(p0.X + shapeSize.Width, p0.Y + shapeSize.Height)};
            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
        }
        public bool inShape(int x, int y)
        {
            return false;
        }
    }
    public class selectedTriangle : CTriangle 
    {
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Black);
            Point[] points = { new Point(p0.X + shapeSize.Width / 2, p0.Y), new Point(p0.X, p0.Y + shapeSize.Height), new Point(p0.X + shapeSize.Width, p0.Y + shapeSize.Height) };
            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
        }
    }
}
