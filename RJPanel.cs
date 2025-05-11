using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.RJControls
{
    public class RJPanel : Panel
    {
        // Поля
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        private int shadowSize = 10;
        private Color shadowColor = Color.Black;

        // Свойства
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        public int ShadowSize
        {
            get { return shadowSize; }
            set { shadowSize = Math.Max(0, value); this.Invalidate(); }
        }

        public Color ShadowColor
        {
            get { return shadowColor; }
            set { shadowColor = value; this.Invalidate(); }
        }

        // Конструктор
        public RJPanel()
        {
            this.DoubleBuffered = true;
        }

        // Метод создания скругленного пути
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Метод отрисовки тени
        private void DrawShadow(Graphics g)
        {
            if (shadowSize > 0)
            {
                Rectangle shadowRect = new Rectangle(
                    shadowSize / 2, // Смещение тени
                    shadowSize / 2,
                    this.Width - shadowSize,
                    this.Height - shadowSize
                );

                using (GraphicsPath shadowPath = GetFigurePath(shadowRect, borderRadius + shadowSize / 2))
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, shadowColor))) // Прозрачная тень
                {
                    g.FillPath(shadowBrush, shadowPath);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Рисуем тень
            DrawShadow(e.Graphics);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.BackColor, borderSize + 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.FillPath(new SolidBrush(this.BackColor), pathSurface);
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
    }
}
