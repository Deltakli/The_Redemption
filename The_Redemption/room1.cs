using System;
using Raylib_cs;

public class Room
{

    public List<Rectangle> wallRect = new();

    public Room()
    {
        wallRect.Add(new Rectangle(1, 550, 1005, 100));
        wallRect.Add(new Rectangle(130, 350, 105, 100));
        wallRect.Add(new Rectangle(400, 270, 105, 100));
    }

    public void Draw()
    {
        for (int i = 0; i < wallRect.Count; i++)
        {
        Raylib.DrawRectangleRec(wallRect[i], Color.GRAY);
        }
    }

}