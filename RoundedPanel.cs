using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 20; // Радиус скругления
    public Color BorderColor { get; set; } = Color.Black; // Цвет рамки
    public int BorderSize { get; set; } = 2; // Толщина рамки

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Включаем сглаживание

        GraphicsPath path = GetRoundedPath(new Rectangle(0, 0, Width, Height), BorderRadius);
        this.Region = new Region(path); // Убираем острые углы

        // Рисуем рамку
        using (Pen pen = new Pen(BorderColor, BorderSize))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

        path.CloseFigure();
        return path;
    }
}
