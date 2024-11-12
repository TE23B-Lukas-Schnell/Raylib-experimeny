using Raylib_cs;

Raylib.InitWindow(1600, 900, "raylib");
Raylib.SetTargetFPS(60);

int circleX = 400;
int cirlceY = 500;

void circleMove()
{
    if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        circleX -= 10;
    }
    if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        circleX += 10;
    }
    if (Raylib.IsKeyDown(KeyboardKey.W))
    {
        cirlceY -= 10;
    }
    if (Raylib.IsKeyDown(KeyboardKey.S))
    {
        cirlceY += 10;
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
}

