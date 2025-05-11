using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.AlternateControls
{
    public class AltRoundedButton : Button
    {
        public int BorderRadius { get; set; } = 15; // Радиус скругления
        public Color BackgroundColor { get; set; } = Color.FromArgb(46, 21, 49); // Цвет фона

        public AltRoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = BackgroundColor;
            ForeColor = Color.White;
            FlatAppearance.BorderSize = 0; // Убираем стандартную границу
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath(ClientRectangle, BorderRadius))
            using (SolidBrush brush = new SolidBrush(BackgroundColor))
            {
                this.Region = new Region(path); // Даем кнопке правильную форму
                graphics.FillPath(brush, path); // Заливаем цветом
            }

            // Отрисовка текста
            TextRenderer.DrawText(
                graphics,
                this.Text,
                this.Font,
                ClientRectangle,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Верхний левый угол
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Верхний правый угол
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Нижний правый угол
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Нижний левый угол
            path.CloseFigure();

            return path;
        }
    }
}
