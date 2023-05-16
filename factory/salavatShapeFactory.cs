using OOP_LAB_4.figures;
namespace OOP_LAB_4.factory
{
    
    public class salavatShapeFactory
    {
        public Shape createShape(int x1, int y1, int x2, int y2, CONST_SHAPE type)
        {
            Shape shape;
            switch (type)
            {
                case CONST_SHAPE.selectedCircle:
                    shape = new selectedCircle(x1, y1, x2, y2); break;

                case CONST_SHAPE.selectedRectangle:
                    shape = new selectedRectangle(x1, y1, x2, y2); break;

                case CONST_SHAPE.selectedTriangle:
                    shape = new selectedTriangle(x1, y1, x2, y2);break;

                default:
                    shape = new selectedCircle(x1,y1, x2, y2);break;
            }
            return shape;
        }
        public void onSelectShape(Shape shape)
        {
            switch (shape.name)
            {
                case CONST_SHAPE.Circle:
                    shape = new selectedCircle(shape);
                    break;
                case CONST_SHAPE.selectedCircle:
                    shape = new CCircle(shape);
                    break;


                case CONST_SHAPE.Rectangle:
                    shape = new selectedRectangle(shape);
                    break;
                case CONST_SHAPE.selectedRectangle:
                    shape = new CRectangle(shape);
                    break;


                case CONST_SHAPE.Triangle:
                    shape = new selectedTriangle(shape); 
                    break;
                case CONST_SHAPE.selectedTriangle:
                    shape = new CTriangle(shape);
                    break;
            }
        }
    }
}
