using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public class Kawatskie_RoundedPanel : Panel
    {
        // Property to customize the border radius
        private int _borderRadius = 20;
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();  // Redraw when the radius changes
                UpdatePanelRegion();  // Update the region when the radius changes
            }
        }

        // Constructor
        public Kawatskie_RoundedPanel()
        {
            this.DoubleBuffered = true;  // Prevent flickering
            this.Resize += (s, e) => UpdatePanelRegion(); // Update the region when resized
            UpdatePanelRegion();  // Initial region setup
        }

        // Create a rounded rectangle path for the panel's background and region
        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arcRect = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // Top-left corner
            path.AddArc(arcRect, 180, 90);
            // Top-right corner
            arcRect.X = bounds.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // Bottom-right corner
            arcRect.Y = bounds.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // Bottom-left corner
            arcRect.X = bounds.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Overriding the OnPaint method to draw the background with rounded corners
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smooth rendering

            // Create a rectangle based on the panel's client area
            Rectangle panelRect = this.ClientRectangle;

            // Create the rounded rectangle path for the background
            using (GraphicsPath backgroundPath = GetRoundedRectanglePath(panelRect, _borderRadius))
            {
                // Fill the panel background (BackColor)
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, backgroundPath);
                }
            }
        }

        // Method to update the panel's region to match the rounded shape
        private void UpdatePanelRegion()
        {
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, _borderRadius))
            {
                this.Region = new Region(path);  // Set the control's region to the rounded path
            }
        }
    }
}




