﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_6
{
    public class Contour
    {
        public List<ILine> lines;
        public List<MyPoint> myPoints;
        public Contour(List<ILine> l)
        {
            lines = l;
            myPoints = new List<MyPoint>();
        }
        public Contour()
        {
            lines = new List<ILine>();
            myPoints = new List<MyPoint>();
        }
        public void Draw(Graphics g, bool allix)
        {
            foreach (MyPoint p in myPoints)
                p.Draw(g, allix);
            foreach (ILine l in lines)
                l.Draw(g, allix);
        }
        public void Draw(Graphics g, bool allix, float x, float y)
        {
            foreach (MyPoint p in myPoints)
                p.Draw(g, allix, x, y);
            foreach (ILine l in lines)
                l.Draw(g, allix, x, y);
        }
        public void ToOnePT(float coef)
        {
            foreach(ILine l in lines)
            {
                l.ToOnePT(coef);
            }
            foreach (MyPoint p in myPoints)
                p.ToOnePT(coef);
        }
        public override string ToString()
        {
            string result = "";
            foreach (ILine l in lines)
                result += "ln:" + l.ToString();
            return result;
        }
    }
}