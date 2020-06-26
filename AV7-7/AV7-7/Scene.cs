using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7_7
{
    public class Scene
    {
        public List<Shape> shapes { get; set; }
        public Color currentcolor { get; set; }
        public Shape selectedShape { get; set; }
        public enum SHAPE_TYPE { CIRCLE , TRIANGLE }
        public void AddShape(Point lokacija, SHAPE_TYPE tip)
        {
            if(tip == SHAPE_TYPE.CIRCLE)
            {
                shapes.Add(new Circle(lokacija, currentcolor));
            }
            else if(tip == SHAPE_TYPE.TRIANGLE)
            {
                shapes.Add(new Triangle(lokacija, currentcolor,
                    new Point(lokacija.X + 30, lokacija.Y + 30), 
                    new Point(lokacija.X, lokacija.Y + 20)));
            }
        }
        public Scene()
        {
            shapes = new List<Shape>();
            currentcolor = Color.Red;
            selectedShape = null;
        }

        public void DrawAll(Graphics g)
        {
            foreach(Shape s in shapes)
            {
                s.Draw(g);
            }
        }
        public void Pulse()
        {
            foreach(Shape s in shapes)
            {
                s.Pulse();
            }
        }
        public void Clicked(Point clickedLocation)
        {
            bool DaliSelektirano = false;
            foreach(Shape s in shapes)
            {
                if(s.Clicked(clickedLocation)==true)
                {
                    selectedShape = s;
                    s.isSelected = true;
                    DaliSelektirano = true;
                }
                else
                {
                    s.isSelected = false;
                }
            }
            if(DaliSelektirano == false)
            {
                selectedShape = null;
            }
        }
    }
}
