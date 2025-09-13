using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SwiftMart
{
    public class RoundedPanel : Panel
    {
        private int borderSize = 0;
        private Color borderColor = DefaultBackColor;
        private BorderRadius borderRadius;

        public RoundedPanel()
        {
            BackColor = Color.DarkBlue;
            ForeColor = Color.White;
            Resize += Panel_Resize;
            BorderRadius = new BorderRadius();
        }

        public BorderRadius BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                borderRadius.PropertyChanged += BorderRadius_PropertyChanged;
                Invalidate();
            }
        }
                
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }


        private void Panel_Resize(object sender, EventArgs e)
        {
            UpdateRoundedCorners();
        }

        private void BorderRadius_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Invalidate(); // Update panel when radius changes
        }

        private void UpdateRoundedCorners()
        {
            using (GraphicsPath path = GetFigurePath(new RectangleF(0, 0, Width, Height),
                                                     borderRadius.TopLeft, borderRadius.TopRight,
                                                     borderRadius.BottomRight, borderRadius.BottomLeft))
            {
                Region = new Region(path);
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float topLeft, float topRight, float bottomRight, float bottomLeft)
        {
            GraphicsPath path = new GraphicsPath();
            float curveTopLeft = topLeft * 2F;
            float curveTopRight = topRight * 2F;
            float curveBottomRight = bottomRight * 2F;
            float curveBottomLeft = bottomLeft * 2F;

            // Top-left corner
            if (topLeft > 0)
                path.AddArc(rect.X, rect.Y, curveTopLeft, curveTopLeft, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            // Top-right corner
            if (topRight > 0)
                path.AddArc(rect.Right - curveTopRight, rect.Y, curveTopRight, curveTopRight, 270, 90);
            else
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);

            // Bottom-right corner
            if (bottomRight > 0)
                path.AddArc(rect.Right - curveBottomRight, rect.Bottom - curveBottomRight, curveBottomRight, curveBottomRight, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

            // Bottom-left corner
            if (bottomLeft > 0)
                path.AddArc(rect.X, rect.Bottom - curveBottomLeft, curveBottomLeft, curveBottomLeft, 90, 90);
            else
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

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

            if (borderRadius.TopLeft > 2 || borderRadius.TopRight > 2 || borderRadius.BottomRight > 2 || borderRadius.BottomLeft > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius.TopLeft, borderRadius.TopRight, borderRadius.BottomRight, borderRadius.BottomLeft))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius.TopLeft - borderSize, borderRadius.TopRight - borderSize, borderRadius.BottomRight - borderSize, borderRadius.BottomLeft - borderSize))
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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BorderRadius : INotifyPropertyChanged
    {
        private int topLeft;
        private int topRight;
        private int bottomRight;
        private int bottomLeft;

        public event PropertyChangedEventHandler PropertyChanged;

        public int TopLeft
        {
            get => topLeft;
            set
            {
                if (topLeft != value)
                {
                    topLeft = value;
                    OnPropertyChanged(nameof(TopLeft));
                }
            }
        }

        public int TopRight
        {
            get => topRight;
            set
            {
                if (topRight != value)
                {
                    topRight = value;
                    OnPropertyChanged(nameof(TopRight));
                }
            }
        }

        public int BottomRight
        {
            get => bottomRight;
            set
            {
                if (bottomRight != value)
                {
                    bottomRight = value;
                    OnPropertyChanged(nameof(BottomRight));
                }
            }
        }

        public int BottomLeft
        {
            get => bottomLeft;
            set
            {
                if (bottomLeft != value)
                {
                    bottomLeft = value;
                    OnPropertyChanged(nameof(BottomLeft));
                }
            }
        }
          
        public BorderRadius(int topLeft = 40, int topRight = 40, int bottomRight = 40, int bottomLeft = 40)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomRight = bottomRight;
            this.bottomLeft = bottomLeft;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            // Display the radii in the property panel
            return $"{TopLeft}, {TopRight}, {BottomRight}, {BottomLeft}";
        }
    }
}
