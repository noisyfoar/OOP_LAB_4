namespace OOP_LAB_4.figures
{
    public class CCircle : Shape
    {
        public Size shapeSize { get ; set; }
        public Point p0 { get; set; }
        public CONST_SHAPE name { get ; set ; }

        public CCircle(int x1, int y1, int x2, int y2)
        {
            name = new CONST_SHAPE();
            shapeSize = new Size();
            p0 = new Point();
            Size new_size = new Size();
            Point new_p0 = new Point();
            name = CONST_SHAPE.Circle;

            if (x1 > x2)
            {
                new_p0.X = x2;
                new_size.Width = x1 - x2;
            }
            else
            {
                new_p0.X = x1;
                new_size.Width = x2 - x1;
            }
            if (y1 > y2)
            {
                new_p0.Y = y2;
                new_size.Height = y1 - y2;
            }
            else
            {
                new_p0.Y = y1;
                new_size.Height = y2 - y1;
            }

            shapeSize = new_size;
            p0= new_p0;
        }
        public CCircle(Shape shape)
        {
            name = CONST_SHAPE.Circle;
            shapeSize = new Size();
            p0 = new Point();
            name = new CONST_SHAPE();
            shapeSize = shape.shapeSize;

            p0= shape.p0;
        }


        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush= new SolidBrush(Color.Black);
            g.FillEllipse(brush, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
            g.DrawEllipse(pen, p0.X, p0.Y, shapeSize.Width, shapeSize.Height);
        }
        public override bool inShape(int x, int y)
        {
            Point center = new Point(p0.X + shapeSize.Width / 2, p0.Y + shapeSize.Height / 2);
            return (Math.Pow(x - center.X, 2) * shapeSize.Height + Math.Pow(y - center.Y, 2) * shapeSize.Width) < (shapeSize.Width * shapeSize.Height);
        }
    }
    public class selectedCircle : CCircle 
    {
        public selectedCircle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            name = CONST_SHAPE.selectedCircle;
        }
        public selectedCircle(Shape shape) : base(shape)
        {
            name = CONST_SHAPE.selectedCircle;
        }


        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Rectangle rect = new Rectangle(p0, shapeSize);
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, rect);
        }
    }
}
