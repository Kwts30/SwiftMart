using SwiftMart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SwiftMart_Final.RoundedControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class RoundedComboBox : UserControl
    {
        // Property Fields
        private int BorderRadius = 20;
        private int BorderSize = 15;
        private Color Back_Color = Color.WhiteSmoke;
        private Color IconColor = Color.MediumSlateBlue;
        private Color ListBackColor = Color.FromArgb(230, 228, 245);
        private Color ListTextColor = Color.DimGray;
        private Color BorderColor = Color.MediumSlateBlue;

        //Combo Items
        private ComboBox CmbList;
        private Label LabelTxt;
        private Button BtnIcon;

        // PROPERTIES
        [Category("CustomAppearance")]
        public new Color BackColor
        {
            get { return Back_Color; }
            set
            {
                Back_Color = value;
                LabelTxt.BackColor = Back_Color;
                BtnIcon.BackColor = Back_Color;
            }
        }
        [Category("CustomAppearance")]
        public Color Icon_Color
        {
            get { return IconColor; }
            set
            {
                IconColor = value;
                BtnIcon.Invalidate();
            }
        }

        [Category("CustomAppearance")]
        public Color List_BackColor
        {
            get { return ListBackColor; }
            set
            {
                ListBackColor = value;
                CmbList.BackColor = ListBackColor;
            }
        }
        [Category("CustomAppearance")]
        public Color List_TextColor
        {
            get { return ListTextColor; }
            set
            {
                ListTextColor = value;
                CmbList.ForeColor = ListTextColor;
            }
        }
        [Category("CustomAppearance")]
        public Color Border_Color
        {
            get { return BorderColor; }
            set
            {
                BorderColor = value;
                base.BackColor = BorderColor;
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
        [Category("CustomAppearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                LabelTxt.ForeColor = value;
            }
        }
        [Category("CustomAppearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                LabelTxt.Font = value;
                CmbList.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("CustomAppearance")]
        public string Texts
        {
            get { return LabelTxt.Text; }
            set { LabelTxt.Text = value; }
        }
        [Category("CustomAppearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return CmbList.DropDownStyle; }
            set
            {
                if (CmbList.DropDownStyle != ComboBoxStyle.Simple)
                    CmbList.DropDownStyle = value;
            }
        }

        // Data
        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return CmbList.Items; }
        }
        [Category("RJ Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return CmbList.DataSource; }
            set { CmbList.DataSource = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return CmbList.AutoCompleteCustomSource; }
            set { CmbList.AutoCompleteCustomSource = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return CmbList.AutoCompleteSource; }
            set { CmbList.AutoCompleteSource = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return CmbList.AutoCompleteMode; }
            set { CmbList.AutoCompleteMode = value; }
        }
        [Category("RJ Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return CmbList.SelectedItem; }
            set { CmbList.SelectedItem = value; }
        }
        [Category("RJ Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return CmbList.SelectedIndex; }
            set { CmbList.SelectedIndex = value; }
        }
        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return CmbList.DisplayMember; }
            set { CmbList.DisplayMember = value; }
        }
        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return CmbList.ValueMember; }
            set { CmbList.ValueMember = value; }
        }

        public event EventHandler OnSelectedIndexChanged;

        public RoundedComboBox()
        {
            CmbList = new ComboBox();
            LabelTxt = new Label();
            BtnIcon = new Button();
            this.MinimumSize = new Size(200, 25);
            this.Size = new Size(200, 25); 
            this.SuspendLayout();


            //Dropdown List
            CmbList.BackColor = ListBackColor;
            CmbList.Font = new Font(this.Font.Name, 10F);
            CmbList.ForeColor = ListTextColor;
            CmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            CmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            //Button
            BtnIcon.Dock = DockStyle.Right;
            BtnIcon.FlatStyle = FlatStyle.Flat;
            BtnIcon.FlatAppearance.BorderSize = 0;
            BtnIcon.BackColor = BackColor;
            BtnIcon.Size = new Size(30, 30);
            BtnIcon.Cursor = Cursors.Hand;
            BtnIcon.Click += new EventHandler(Icon_Click); 
            BtnIcon.Paint += new PaintEventHandler(Icon_Paint);

            //Text
            LabelTxt.Dock = DockStyle.Fill;
            LabelTxt.AutoSize = false;
            LabelTxt.BackColor = BackColor;
            LabelTxt.TextAlign = ContentAlignment.MiddleLeft;
            LabelTxt.Padding = new Padding(8, 0, 0, 0);
            LabelTxt.Font = new Font(this.Font.Name, 10F);

            //Attach label events to user control event
            LabelTxt.Click += new EventHandler(Surface_Click); //Select combo box 
            LabelTxt.MouseEnter += new EventHandler(Surface_MouseEnter);
            LabelTxt.MouseLeave += new EventHandler(Surface_MouseLeave);

            this.Controls.Add(LabelTxt);//2
            this.Controls.Add(BtnIcon);//1
            this.Controls.Add(CmbList);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(BorderSize);//Border Size
            this.Font = new Font(this.Font.Name, 10F);
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void AdjustComboBoxDimensions()
        {
            CmbList.Width = this.Width - BtnIcon.Width - this.Padding.Left - this.Padding.Right;
            CmbList.Location = new Point(this.Padding.Left, this.Padding.Top);
        }
        private void UpdateControlHeight()
{
    // Ensure the ComboBox is initialized
    if (CmbList != null)
    {
        // Measure the height of the ComboBox
        int comboBoxHeight = CmbList.PreferredHeight;

        // Add any additional padding you want
        int totalHeight = comboBoxHeight + this.Padding.Top + this.Padding.Bottom;

        // Set the height of the RoundedComboBox
        this.Height = totalHeight;
    }
}
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
           
            LabelTxt.Text = CmbList.Text;
        }
       
        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            CmbList.Select();
            CmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            //Attach label click to user control click
            this.OnClick(e);
            //Select combo box
            CmbList.Select();
            if (CmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                CmbList.DroppedDown = true;//Open dropdown list
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            LabelTxt.Text = CmbList.Text;
        }
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((BtnIcon.Width - iconWidht) / 2, (BtnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(IconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
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
            RectangleF rectBorder = RectangleF.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = 2;
            if (BorderSize > 0)
                smoothSize = BorderSize;

            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Region = new Region(pathSurface);

                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (BorderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                Region = new Region(rectSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }

            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

    }
}
