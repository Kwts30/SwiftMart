using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftMart.RoundedControls
{
    public class RoundedBtn : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = DefaultBackColor;

        public RoundedBtn()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.LightGreen;
            ForeColor = Color.White;
            Resize += new EventHandler(Panel_Resize);

        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                if (value >= 0)
                {

                    borderRadius = value;
                    Invalidate();
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rectSurface = ClientRectangle;
            RectangleF rectBorder = RectangleF.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Region = new Region(pathSurface);

                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
