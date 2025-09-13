using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftMart_Final.RoundedControls
{
    public class RoundedDateTimePicker : DateTimePicker
    {
        // Fields
        private int BorderRadius = 15;
        private int BorderSize = 2;
        private Color BorderColor = Color.FromArgb(214, 228, 255);
        private Color BGColor = Color.FromArgb(214, 228, 255);
        private Color TxtColor = Color.Black;
        
        // Other fields
        private bool DroppedDown = false;
        private Image CalendarIcon = Properties.Resources.calendarDark;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;


        // Custom Properties
        [Category("CustomAppearance")]
        public Color TextColor
        {
            get { return TxtColor; }
            set
            {
                TxtColor = value;
                this.Invalidate();


            }

        }
        [Category("CustomAppearance")]
        public int Border_Size
        {
            get { return BorderSize; }
            set
            {
                BorderSize = value;
                this.Invalidate();
            }
        }
        [Category("CustomAppearance")]
        public Color Border_Color
        {
            get { return BorderColor; }
            set
            {
                BorderColor = value;
                this.Invalidate();
            }
        }
        [Category("CustomAppearance")]
        public int Border_Radius
        {
            get
            {
                return BorderRadius;
            }
            set
            {
                if (value >= 0)
                {

                    BorderRadius = value;
                    Invalidate();
                }
            }
        }

        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
        // Constructor
        public RoundedDateTimePicker ()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "MM/dd/yyyy";
        }

        // Override
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            DroppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            DroppedDown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            using (SolidBrush skinBrush = new SolidBrush(BGColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(TxtColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;
                textFormat.Alignment = StringAlignment.Near;
                // Rounded border
                if (BorderRadius > 2)
                {
                    using (GraphicsPath pathSurface = GetFigurePath(clientArea, BorderRadius))
                    using (Pen penSurface = new Pen(this.Parent.BackColor, BorderSize))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        this.Region = new Region(pathSurface);
                        graphics.FillPath(skinBrush, pathSurface);
                        if (DroppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                        if (BorderSize >= 1)
                            graphics.DrawPath(penBorder, pathSurface);
                    }
                }
                else
                {
                    // Default to drawing regular rectangle if no rounded borders
                    this.Region = new Region(clientArea);
                    graphics.FillRectangle(skinBrush, clientArea);
                    if (BorderSize >= 1)
                        graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }

                //Draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                string formattedDate = this.Value.ToString("MM/dd/yyyy");  // Custom format
                graphics.DrawString(formattedDate, this.Font, textBrush, clientArea, textFormat);               
                //Draw open calendar icon highlight
                if (DroppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                //Draw border
                if (BorderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                //Draw icon
                graphics.DrawImage(CalendarIcon, this.Width - CalendarIcon.Width - 9, (this.Height - CalendarIcon.Height) / 2);
                
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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
           
        }
    }
}
