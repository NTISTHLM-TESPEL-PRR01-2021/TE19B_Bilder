using System;
using Raylib_cs;

namespace Bilder
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Raylib.InitWindow(800, 600, "Bilder och grejer");

      // Image - RAM-minnet, kan ändras på
      // Texture - Grafikkortet, kan ej ändras på, kan ritas ut

      Texture2D mike = Raylib.LoadTexture("mike.png");

      float mikeX = 0;
      float mikeY = 0;

      string scene = "intro";

      while (!Raylib.WindowShouldClose())
      {
        // mikeX += 0.05f;

        // LOGIC:

        if (scene == "intro")
        {
          if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
          {
            scene = "game";
          }
        }
        else if (scene == "game")
        {
          if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
          {
            mikeX += 0.1f;
          }
          else if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
          {
            mikeX -= 0.1f;
          }
          if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
          {
            scene = "intro";
          }
        }

        // DRAWING:
        Raylib.BeginDrawing();

        if (scene == "intro")
        {
          Raylib.ClearBackground(Color.LIME);
        }
        else if (scene == "game")
        {
          Raylib.ClearBackground(Color.MAROON);
          Raylib.DrawTexture(mike, (int) mikeX, (int) mikeY, Color.WHITE);
        }


        Raylib.EndDrawing();
      }

    }
  }
}
