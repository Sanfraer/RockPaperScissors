using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 20; // Радиус закругления

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, BorderRadius * 2, BorderRadius * 2, 180, 90);
        path.AddArc(Width - BorderRadius * 2, 0, BorderRadius * 2, BorderRadius * 2, 270, 90);
        path.AddArc(Width - BorderRadius * 2, Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 0, 90);
        path.AddArc(0, Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        using (Pen pen = new Pen(Color.Black, 2))
        {
            pevent.Graphics.DrawPath(pen, path);
        }
    }
}
