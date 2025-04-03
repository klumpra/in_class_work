using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDrawingTool20250402 {
    public class DrawingController {
        public DrawingForm View;
        public DrawingModel Model;
        private bool isDrawing;
        public DrawingController(DrawingModel model, DrawingForm view) {
            isDrawing = false;
            Model = model;
            View = view;
            View.panDrawing.MouseDown += OnMouseDown;
            View.panDrawing.MouseMove += OnMouseMove;
            View.panDrawing.MouseUp += OnMouseUp;
            view.panDrawing.Paint += OnPaint;
            view.ClearRequested += OnClearRequested;
        }
        private void OnMouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isDrawing = true;
                Model.AddLine(e.Location);
                View.panDrawing.Invalidate(); // repaints the panDrawing
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e) {
            if (isDrawing) {
                Model.ContinueLine(e.Location);
                View.panDrawing.Invalidate();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isDrawing = false;
            }
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            foreach (var line in Model.Lines) {
                if (line.Count > 1) {
                    e.Graphics.DrawLines(Pens.Black, line.ToArray());
                }
            }
        }

        private void OnClearRequested(object sender, EventArgs e) {
            Model.Clear();
            View.panDrawing.Invalidate();
        }
    }
}
