using System;
using Raylib_cs;

public class Enemy
{
    public int X = 0;
    public int Y = 0;
    public bool IsDead = false;

    public Rectangle rectangle;

    public Enemy()
    {
       rectangle = new(X, Y, 100, 100);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rectangle, Color.BLACK);
    }
}