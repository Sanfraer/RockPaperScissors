using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Windows.Forms;

public class VignetteButton : RJButton
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Создаём градиент для эффекта вьеттирования
        using (Graphics g = pevent.Graphics)
        {
            // Создание радиального градиента (затухание)
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                rect, Color.Transparent, Color.Black, 45F))
            {
                g.FillRectangle(brush, rect);
            }
        }
    }
}