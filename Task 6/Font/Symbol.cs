﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_6
{
    class Symbol
    {
        public char symbol;
        public List<Contour> contours;
        public Symbol(char s, List<Contour> c)
        {
            symbol = s;
            contours = c;
        }
        public Symbol(char s)
        {
            symbol = s;
            contours = new List<Contour>();
        }
        public Symbol()
        {
            contours = new List<Contour>();
        }
        public void Draw(Graphics g)
        {
            foreach (Contour c in contours)
                c.Draw(g, true);
        }
        public override string ToString()
        {
            string result = symbol.ToString() + " ";
            foreach (Contour c in contours)
                result += c.ToString();
            return result;
        }
    }
}