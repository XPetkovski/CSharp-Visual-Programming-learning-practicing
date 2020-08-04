﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> Circles { get; set; }
        public CircleDoc()
        {
            Circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            for(int i = 0; i < Circles.Count; i++)
            {
                Circles[i].Draw(g);
            }
        }

        public void AddCircle(Point point, int width, int height)
        {
            Circle c = new Circle(point, width, height);
            Circles.Add(c);
        }

        public void ChangeColor()
        {
            for(int i = 0; i<Circles.Count; i++)
            {
                Circles[i].ChangeColor();
            }
        }
    }
}
