using System;
using Raylib_cs;
using System.Numerics;

public class Character
{
    public string name;
    public int hp;
    public Rectangle rect = new Rectangle(150, 150, 85, 100);

    public Texture2D playerImage = Raylib.LoadTexture("piskel.png");


    public Vector2 GetPosition()
    {
        return new Vector2(rect.x, rect.y);
      }

    public void Damage(int amount)
    {

        hp -= amount;

    }

    public void Draw()
    {

        Texture2D playerImage = Raylib.LoadTexture("piskel.png");
       // Raylib.DrawRectangleRec(rect, Color.YELLOW);
        Raylib.DrawText($"{hp}", (int)rect.x + 30, (int)rect.y - 35, 20, Color.BLACK);
        Raylib.DrawTexture(playerImage, (int)rect.x, (int)rect.y, Color.WHITE);

    }
}