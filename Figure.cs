using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public abstract class Figure
{
    protected int x;
    protected int y;
    protected Form form;

    public Figure(int x, int y, Form form)
    {
        if (form == null)
        {
            throw new ArgumentNullException(nameof(form), "Form should not be null.");
        }
        this.x = x;
        this.y = y;
        this.form = form;
    }
    public abstract void DrawBlack();
    public abstract void HideDrawingBackGround();

    public void MoveRight()
    {
        for (int i = 0; i < 5; i++)
        {
            x += 5;
            DrawBlack();
          
            Thread.Sleep(100);
            HideDrawingBackGround();
        }
    }
}
