using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDrawingTool20250402 {
    public class DrawingModel {
        public List<List<Point>> Lines;
        public DrawingModel() {
            Lines = new List<List<Point>>();   
        }
        public void AddLine(Point point) {
            List<Point> line = new();
            line.Add(point);
            Lines.Add(line);
        }
        public void ContinueLine(Point point) {
            Lines[Lines.Count - 1].Add(point);
        }
        public void Clear() {
            Lines.Clear();
        }
    }
}
