using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4.figures
{
    public interface IShape
    {
        Size shapeSize { get; set; } // size of box where will be shape
        Point p0 { get; set; } // topleft point

        public void Draw(Graphics g);

        public void resize(Size imageSize, int delta)
        {
            Size newSize = new Size(shapeSize.Width + delta, shapeSize.Height + delta);
            shapeSize = newSize;
            move(imageSize, 0, 0);
        }

        public void move(Size imageSize, int dx, int dy)
        {
            Point new_p0 = new Point(p0.X + dx, p0.Y + dy);

            if( new_p0.X + shapeSize.Width > imageSize.Width)
            {
                new_p0.X = imageSize.Width - shapeSize.Width;
            }
            if(new_p0.X < 0)
            {
                new_p0.X = 0;
            }
            if(new_p0.Y + shapeSize.Height > imageSize.Height)
            {
                new_p0.Y = imageSize.Height - shapeSize.Height;
            }
            if(new_p0.Y < 0)
            {
                new_p0.Y = 0;
            }
            p0= new_p0;
        }

        public bool inShape(int x, int y);

    }
    public class help_vector
    {
        public int dx, dy;
        public help_vector(int dx = 0, int dy = 0)
        {
            this.dx = dx;
            this.dy = dy;
        }
        public help_vector(Point a, Point b)
        {
            this.dx = a.X - b.X;
            this.dy = a.Y - b.Y;
        }
        public static int operator *(help_vector a, help_vector b)
        {
            return a.dx * b.dy - a.dy * b.dx;
        }
    }
}
