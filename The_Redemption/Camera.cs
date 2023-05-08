using System;
using Raylib_cs;
using System.Numerics;
public class Camera
{

    private Character TheMove;

     //position för kameran
    Vector2 offset = new Vector2(35, -100);
    private Camera2D camera2D;
    public Camera(Character tgt)
    {
        TheMove = tgt;
        camera2D = new()
        {
            target = new Vector2(),
            offset = new Vector2(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2),
            zoom = 1.1f,
        };
    }

    public void BeginCamera()
    {
        Raylib.BeginMode2D(camera2D);
    }

    public void EndCamera()
    {
        Raylib.EndMode2D();
    }

    public Camera2D GetCamera2D()
    {
        return camera2D;
    }
        
        //konstanta updaterande kamera
    public void update()
    {

        camera2D.target  = new Vector2(TheMove.rect.x + 55, TheMove.rect.y + 35);

    }

}