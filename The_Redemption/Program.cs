global using System;
global using Raylib_cs;
global using System.Numerics;


Raylib.InitWindow(800, 600, "Sidescroller");
Raylib.SetTargetFPS(60);

// Alla kalleser till de klasser de tillhör till

Main cs = new Main();
Room r1 = new Room();
Enemy e1 = new Enemy();
Enemy e2 = new Enemy();
Enemy e3 = new Enemy();


Camera camera = new Camera(cs);

cs.name = "Bertil";
cs.Damage(0);

Camera2D cam = new Camera2D(Vector2.Zero, Vector2.Zero, 0, 1.0f);

while (!Raylib.WindowShouldClose() && cs.hp > 0)
{

    e1.rectangle.x = 60;
    e1.rectangle.y = 40;
    e2.rectangle.x = 200;
    e2.rectangle.y = 450;
    e3.rectangle.x = 2000;
    e3.rectangle.y = 200;


    cs.movement(r1);


    camera.update();
    
    cs.CheckCollision(e1);
    cs.CheckCollision(e2);
    cs.CheckCollision(e3);

    Raylib.BeginDrawing();
    camera.BeginCamera();

    Raylib.ClearBackground(Color.DARKBLUE);

    cs.Draw();
    r1.Draw();
    e1.Draw();
    e2.Draw();
    e3.Draw();
    

    camera.EndCamera();


    Raylib.EndDrawing();
}