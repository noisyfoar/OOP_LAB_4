using System.Windows.Forms;

namespace OOP_LAB_4
{
    public partial class Form1 : Form
    {
        List<Circle> circles;
        CheckBoxs model;
        
        int radius;

        int CursorX;
        int CursorY;

        Graphics g;
        Brush BlackBrush;
        Brush RedBrush;

        public Form1()
        {
            InitializeComponent();

            panel1.MouseUp += Form1_MouseUp;

            model = new CheckBoxs(checkBox_CTRL.Checked, checkBox_Multiple.Checked);
            model.observers += new EventHandler(UpdateFromCheckBoxs);

            circles = new();

            radius = 50;

            CursorX = 0;
            CursorY = 0;

            g = panel1.CreateGraphics();
            BlackBrush = new SolidBrush(Color.Black);
            RedBrush = new SolidBrush(Color.Red);
        }
        public void UpdateFromCheckBoxs(object sender, EventArgs e)
        {
            checkBox_CTRL.Checked = model.get_check_ctrl();
            checkBox_Multiple.Checked = model.get_check_multiple();
        }
       
        private void checkBox_Multiple_CheckedChanged(object sender, EventArgs e)
        {
            model.setMultiple(checkBox_Multiple.Checked);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Circle c in circles)
            {
                if (c.getColor())
                    c.draw(g, RedBrush);
                else
                    c.draw(g, BlackBrush);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bool count = false;
            bool check = true;

            CursorX = e.X;
            CursorY = e.Y;

            foreach (Circle c in circles)
            {
                if (c.inCircle(CursorX, CursorY))
                {
                    if (!count && model.get_check_multiple())
                    {
                        model.setCtrl(false);
                        check = false;
                        c.color_changed();
                        count = true;
                    } 
                    else if (model.get_check_multiple())
                    {
                        model.setCtrl(false);
                        check = false;
                        c.setColor(false);
                        continue;
                    }
                    else
                    {
                        model.setCtrl(false);
                        check = false;
                        c.color_changed();
                    }
                }
                else if (Form.ModifierKeys != Keys.Control)
                {
                    c.setColor(false);
                    model.setCtrl(false);
                }
                else
                {
                    model.setCtrl(true);
                }
            }

            if (check)
            {
                foreach (Circle c in circles)
                {
                    c.setColor(false);
                }
                Circle circle = new Circle(CursorX, CursorY, radius);
                circles.Add(circle);
                model.setCtrl(false);
            }
            panel1.Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                g.Clear(SystemColors.Control);
                circles.Clear();
            }
        }
    }

    class CheckBoxs
    {
        private bool check_ctrl;
        private bool check_multiple;
        public EventHandler observers;
        public CheckBoxs()
        {
            check_ctrl = false;
            check_multiple = false;
        }
        public CheckBoxs(bool ctrl, bool multiple)
        {
            check_ctrl = ctrl;
            check_multiple = multiple;
        }
        public bool get_check_ctrl()
        {
            return check_ctrl;
        }
        public bool get_check_multiple()
        {
            return check_multiple;
        }

        public void setCtrl(bool check)
        {
            check_ctrl = check;
            observers.Invoke(this, null);
        }
        public void setMultiple(bool multiple)
        {
            check_multiple = multiple;
            observers.Invoke(this, null);
        }

    }
    class Circle
    {
        private int x, y, rad;
        private bool color; // true => red false => black
        public Circle(int x, int y, int rad) {
            this.x = x;
            this.y = y;
            this.rad = rad;
            color = true;
        }
        
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getRad() 
        { 
            return rad;
        }
        public int getSquareRad()
        {
            return rad*rad;
        }
        public bool getColor()
        {
            return color;
        }
        public void setColor(bool color)
        {
            this.color = color;
        }
        public void color_changed()
        {
            color = !color;
        }
        public int getSquareDistToPointFromCentre(int point_x, int point_y)
        {
            int squareDist = (point_x - x) * (point_x - x) + (point_y - y) * (point_y - y);
            return squareDist;
        }

        public void draw(Graphics g, Brush brush)
        {
            g.FillEllipse(brush, x - rad, y - rad, rad * 2, rad * 2);
        }
        public bool inCircle(int point_x, int point_y) {
            if(getSquareDistToPointFromCentre(point_x, point_y) < getSquareRad())
            return true;
            return false;
        }


    }
}