using OOP_LAB_4.figures;
using System.Drawing;


    namespace OOP_LAB_4.figures
    {
        public class CTriangle : Shape
        {
            public Size shapeSize { get; set; }
            public Point p0 { get; set; }
            public help_vector[] vectors { get; set; }
            public Point[] points { get; set; }
            public CONST_SHAPE name { get; set; }

            public CTriangle(int x1, int y1, int x2, int y2)
            {
                name = new CONST_SHAPE();
                shapeSize = new Size();
                p0 = new Point();

                vectors = new help_vector[6];
                points= new Point[3];

                name = CONST_SHAPE.Triangle;

                Size new_size = new Size();
                Point new_p0 = new Point();

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

                points[0] = new Point(p0.X + shapeSize.Width / 2, p0.Y); // A vertex
                points[1] = new Point(p0.X, p0.Y + shapeSize.Height); // B vertex
                points[2] = new Point(p0.X + shapeSize.Width, p0.Y + shapeSize.Height); // C vertex

                vectors[3] = new help_vector(points[0], points[1]);
                vectors[4] = new help_vector(points[1], points[2]);
                vectors[5] = new help_vector(points[2], points[0]);
            }
            public CTriangle(Shape shape)
            {
                shapeSize = new Size();
                p0 = new Point();
                name = new CONST_SHAPE();
                shapeSize = shape.shapeSize;
                p0= shape.p0;
                name = CONST_SHAPE.Triangle;
            }


            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black);
                Brush brush = new SolidBrush(Color.Black);
                g.DrawPolygon(pen, points);
                g.FillPolygon(brush, points);
            }
            public override bool inShape(int x, int y)
            {
                Point O = new Point(x, y); // O point - into or out triangle
                vectors[0] = new help_vector(O, points[0]);
                vectors[1] = new help_vector(O, points[1]);
                vectors[2] = new help_vector(O, points[2]);

                int OA_AB = vectors[0] * vectors[3];
                int OB_BC = vectors[1] * vectors[4];
                int OC_CA = vectors[2] * vectors[5];

                if (((OA_AB < 0) && (OB_BC < 0) && (OC_CA < 0)) || ((OA_AB >= 0) && (OB_BC >=0) && (OC_CA >= 0)))
                    return true;
                return false;
            }
        }
        public class selectedTriangle : CTriangle
        {
            public selectedTriangle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
            {
                name = CONST_SHAPE.selectedTriangle;
            }
            public selectedTriangle(Shape shape) : base(shape)
            {
                name = CONST_SHAPE.selectedTriangle;
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

