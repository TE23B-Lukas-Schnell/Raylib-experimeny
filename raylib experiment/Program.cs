using Raylib_cs;
using System;

Console.WriteLine("Hur mycket fps vill du ha?");
int targetFrameRate;
while (!int.TryParse(Console.ReadLine(), out targetFrameRate) || targetFrameRate < 0)
{
    Console.WriteLine("invalid input, try again");
}

int deltaTime() => targetFrameRate / (int)MathF.Round(Raylib.GetFrameTime());

Raylib.InitWindow(1600, 900, "raylib");
Raylib.MaximizeWindow();
Raylib.SetTargetFPS(targetFrameRate);

int circleX = 400;
int cirlceY = 500;

void circleMove()
{
    if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        circleX -= 10 * deltaTime();
    }
    if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        circleX += 10 * deltaTime();
    }
    if (Raylib.IsKeyDown(KeyboardKey.W))
    {
        cirlceY -= 10 * deltaTime();
    }
    if (Raylib.IsKeyDown(KeyboardKey.S))
    {
        cirlceY += 10 * deltaTime();
    }
}
while (!Raylib.WindowShouldClose())
{

    circleMove();
    Raylib.DrawCircle(circleX, cirlceY, 100, Color.Black);
    Raylib.DrawCircle(100, 100, 100, Color.DarkPurple);

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);
    Raylib.EndDrawing();
    Raylib.DrawText(/*Raylib.GetFPS().ToString()/*/"båt", 100, 50, 20, Color.Black);

}

class movingObject()
{
    int x, y;
    int xSpeed, ySpeed;
    int gravity; // put zero if it isn't affected by gravity

    void moveObject()
    {
        x += xSpeed;
        y += ySpeed;

    }

}
