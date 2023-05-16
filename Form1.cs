using OOP_LAB_4.factory;
using OOP_LAB_4.figures;
using System.Windows.Forms;

namespace OOP_LAB_4
{
    
    public partial class Form1 : Form
    {
        List<Shape> shapes;

        int CursorX;
        int CursorY;
        int x1, y1, x2, y2;

        bool create;

        Graphics g;

        CONST_SHAPE selectedShape;

        salavatShapeFactory shapeFactory;

        public Form1()
        {
            InitializeComponent();


            panel1.MouseUp += Form1_MouseUp;
            panel1.MouseDown+= Form1_MouseDown;

            shapes = new();
            shapeFactory = new();


            selectedShape = CONST_SHAPE.selectedCircle;


            CursorX = 0;
            CursorY = 0;
            x1 = 0; y1 = 0; x2 = 0; y2 = 0;


            g = panel1.CreateGraphics();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape c in shapes)
            {
                c.Draw(g);
            }
        }

        private void toolStripTextBoxCircle_Click(object sender, EventArgs e)
        {
            selectedShape = CONST_SHAPE.selectedCircle;
        }

        private void toolStripTextBoxRectangle_Click(object sender, EventArgs e)
        {
            selectedShape = CONST_SHAPE.selectedRectangle;
        }

        private void toolStripTextBoxTriangle_Click(object sender, EventArgs e)
        {
            selectedShape = CONST_SHAPE.selectedTriangle;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            CursorX = e.X; CursorY = e.Y;
            if(shapes.Count> 0 )
            {
                foreach (Shape c in shapes)
                {
                    if (c.inShape(CursorX, CursorY))
                    {
                        create = false;
                    }
                    else
                    {
                        x1 = CursorX; y1 = CursorY;
                        create = true;
                    }
                }
            }
            else
            {
                x1 = CursorX; y1 = CursorY;
                create = true;
            }
            
            panel1.Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            CursorX = e.X; CursorY = e.Y;
            if(create)
            {
                x2 = CursorX; y2 = CursorY;
                Shape shape = shapeFactory.createShape(x1, y1, x2, y2, selectedShape);
                shapes.Add(shape);
                create = false;
            }
            panel1.Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                g.Clear(SystemColors.Control);
                shapes.Clear();
            }
        }

    }
   
}