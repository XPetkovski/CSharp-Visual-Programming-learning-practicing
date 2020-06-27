using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV8
{
    public class Scene
    {
        public List<Line> lines { get; set; }
        public Color Color { get; set; }
        public float Thickness { get; set; }
        public bool Positioner { get; internal set; }

        public Point CurrentPoint { set; get; }
        int Width;
        int Height;

        public Point PreviousPoint = Point.Empty;
        Stack<Action> UndoStack;
        Stack<Action> RedoStack;
        public Scene(int Width, int Height) 
        {
            lines = new List<Line>();
            Color = Color.Black;
            Thickness = 2;

            UndoStack = new Stack<Action>();
            RedoStack = new Stack<Action>();

            this.Width = Width;
            this.Height = Height;
        }

        public void AddLine(Point point)
        {
            if(!this.PreviousPoint.IsEmpty)
            {
                Line NewLine = new Line(PreviousPoint, point, Thickness, Color);
                lines.Add(NewLine);
                UndoStack.Push(new Action(NewLine));
            }
            PreviousPoint = point;
        }

        public void DrawAll(Graphics g)
        {
            foreach(Line l in lines)
            {
                l.draw(g);
            }

            if(Positioner == true)
            {
                Pen pn = new Pen(Color.Gray, 1);
                pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                g.DrawLine(pn, new Point(0, CurrentPoint.Y), new Point(Width, CurrentPoint.Y));

                g.DrawLine(pn, new Point(CurrentPoint.X, 0), new Point(CurrentPoint.X, Height));

                pn.Dispose();
            }
        }

        public int LinesCount()
        {
            return lines.Count();
        }

        public void Move(int dx, int dy)
        {
            foreach(Line l in lines)
            {
                l.move(dx, dy);
            }
            PreviousPoint = new Point(PreviousPoint.X + dx, PreviousPoint.Y + dy);
        }

        public void Undo()
        {
            if(UndoStack.Count != 0)
            {
                Action actionRemoved = UndoStack.Pop();
                RedoStack.Push(actionRemoved);
                lines.RemoveAt(lines.Count - 1);
            }
            PreviousPoint = lines[lines.Count - 1].End;
        }

        public void Redo()
        {
            if(UndoStack.Count != 0)
            {
                Action actionToRedo = RedoStack.Pop();
                lines.Add(actionToRedo.Line);
                UndoStack.Push(actionToRedo);
            }
        }
        
    }
}
