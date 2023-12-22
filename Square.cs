using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class Square : Figure
{
    private int sideLength;

    public Square(int x, int y, int sideLength, Form form) : base(x, y, form)
    {
       /* if (sideLength <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(sideLength), "Side length should be greater than 0.");
        }*/
        this.sideLength = sideLength;
    }


    public override void DrawBlack()
    {
        using (Graphics g = form.CreateGraphics())
        {
            g.FillRectangle(Brushes.Black, x, y, sideLength, sideLength);
        }
    }

    public override void HideDrawingBackGround()
    {
        using (Graphics g = form.CreateGraphics())
        {
            g.FillRectangle(Brushes.WhiteSmoke, x, y, sideLength, sideLength);
        }
    }
}
