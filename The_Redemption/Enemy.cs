using System;
using Raylib_cs;

  //firnde klass 
public class Enemy
{
    public int X = 0;
    public int Y = 0;
    public bool IsDead = false;

    public Rectangle rectangle;

     // fiende position och storlek
    public Enemy()
    {
       rectangle = new(X, Y, 100, 100);
    }

       //Ritar fiende
    public void Draw()
    {
        Raylib.DrawRectangleRec(rectangle, Color.BLACK);
    }
}