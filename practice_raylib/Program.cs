using Raylib_cs;
using System;

namespace Greed_Game
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int screenWidth = (Raylib.GetScreenWidth());
            int screenHeight = (Raylib.GetScreenHeight());
            Raylib.InitWindow(2200, 1600, "Creations");
            Raylib.SetTargetFPS(100);
            int x = 100;
            int y = 100;
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                Raylib.DrawCircle(x, y, 30, Color.SKYBLUE);
                Raylib.DrawRectangle((x+200), (y+10), 200, 200, Color.DARKPURPLE);
                Raylib.DrawFPS(0, 0);
                x++;
                y++;

                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}