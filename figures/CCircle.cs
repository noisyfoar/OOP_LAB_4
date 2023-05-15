using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4.figures
{
    public class CCircle : IShape
    {
        public Size shapeSize { get ; set; }
        public Point p0 { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush= new SolidBrush(Color.Black);
            g.DrawEllipse(pen, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
            g.FillEllipse(brush, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
        }
        public bool inShape(int x, int y)
        {
            Point center = new Point(p0.X + shapeSize.Width / 2, p0.Y + shapeSize.Height / 2);
            return Math.Pow(x - center.X, 2) * shapeSize.Height + Math.Pow(y - center.Y, 2) * shapeSize.Width < shapeSize.Width * shapeSize.Height;
        }
    }
    public class selectedCircle : CCircle 
    {
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawEllipse(pen, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
            g.FillEllipse(brush, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
        }
    }
}
