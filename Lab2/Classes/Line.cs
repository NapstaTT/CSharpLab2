using System;

namespace Lab2.Classes
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"Линия от {{{Start}}} до {{{End}}}";
        }
    }
}