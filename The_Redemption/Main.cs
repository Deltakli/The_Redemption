using System;
using Raylib_cs;


public class Main : Character
{
    float gravity = 0;
    float acceleration = 0.3f;
    bool inair;



    public Main()
    {
        name = "Bert";
        hp = 100;
    }

    public void CheckCollision(Enemy enemy)
    {
            if (Raylib.CheckCollisionRecs(rect, enemy.rectangle))
            {
                 hp -= 1;

                if ( hp < 0)
                {
                      Console.WriteLine("Game Over");
                      Console.ReadKey();
                      Environment.Exit(0);
                }

            }       
    }

    public void movement(Room room)
    {

        float xMovement = 0;
        float yMovement = 0;

        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            xMovement = 5;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            xMovement = -5;
        }

        rect.x += xMovement;

        Console.WriteLine(inair);
        gravity += acceleration;
        // rect.y += yMovement;
        inair = true;
        for (int i = 0; i < room.wallRect.Count; i++)
        {
            if (Raylib.CheckCollisionRecs(rect, room.wallRect[i]))
            {
                // Console.WriteLine("colliding");
                inair = false;
                gravity = 0;
            }
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && inair == false)
        {
            gravity = -8;
        }


        rect.y += gravity;

    }
}