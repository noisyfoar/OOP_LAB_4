using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4.figures
{
    public class CRectangle : IShape
    {
        public Size shapeSize { get ; set ; }
        public Point p0 { get ; set; }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
            g.FillRectangle(brush, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
        }
        public bool inShape(int x, int y)
        {
            if((x >= p0.X) && ( y >= p0.Y))
                if((x <= p0.X + shapeSize.Width ) && (y <= p0.Y + shapeSize.Height))
                    return true;
            return false;
        }
    }
    public class selectedRectangle : CRectangle {
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
            g.FillRectangle(brush, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
        }
    }
}
