﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_6
{
    class Line: ILine
    {
        MyPoint P1;
        MyPoint P2;
        bool Current;
        public Line(MyPoint p1, MyPoint p2)
        {
            P1 = p1;
            P2 = p2;
            Current = false;
        }
        public bool Check()
        {
            return (P1 == null || P2 == null);
        }
        public void PointByIndex(int n, MyPoint p)
        {
            if (n == 0)
                P1 = p;
            if (n == 1)
                P2 = p;
        }
        public List<MyPoint> GetPoints()
        {
            List<MyPoint> points = new List<MyPoint>();
            points.Add(P1);
            points.Add(P2);
            return points;
        }
        public void Draw(Graphics g, bool allix, int pt, float x, float y, ScreenConverter sc)
        {
            if (Current)
                g.DrawLine(Pens.Red, sc.II(P1.X) * pt + x, sc.JJ(P1.Y) * pt + y, sc.II(P2.X) *pt + x, sc.JJ(P2.Y) * pt + y);
            else
                g.DrawLine(Pens.Black, sc.II(P1.X) * pt + x, sc.JJ(P1.Y) * pt + y, sc.II(P2.X) * pt + x, sc.JJ(P2.Y) * pt + y);
        }
        public void Draw(Graphics g, bool allix, ScreenConverter sc)
        {
            if (Current)
                g.DrawLine(Pens.Red, sc.II(P1.X), sc.JJ(P1.Y), sc.II(P2.X), sc.JJ(P2.Y));
            else
                g.DrawLine(Pens.Black, sc.II(P1.X), sc.JJ(P1.Y), sc.II(P2.X), sc.JJ(P2.Y));
        }
        public void Draw(Graphics g, bool allix, int pt, float x, float y)
        {
            if (Current)
                g.DrawLine(Pens.Red, (float)(P1.X * pt + x), (float)(P1.Y * pt + y), (float)(P2.X * pt + x), (float)(P2.Y * pt + y));
            else
                g.DrawLine(Pens.Black, (float)(P1.X * pt + x), (float)(-P1.Y * pt + y), (float)(P2.X * pt + x), (float)(-P2.Y * pt + y));
        }
        public override string ToString()
        {
            return  P1.X.ToString() + "," + P1.Y.ToString() + "," + P2.X.ToString() + "," + P2.Y.ToString() + " "; 
        }
    }
}
