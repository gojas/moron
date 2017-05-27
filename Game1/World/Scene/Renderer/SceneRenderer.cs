using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace World.Scene.Renderer
{
    using World.GameObject;

    public class SceneRenderer
    {
        Scene scene;

        public SceneRenderer(Scene scene)
        {
            this.scene = scene;
        }

        public void Render()
        {
            int[,] objects = scene.GetGameObjectMatrix();

            int i = 0;
            int offset_x;
            int tile_width = 126;

            foreach (int objectId in objects)
            {
                if (IsOdd(i))
                    offset_x = tile_width / 2;
                else
                    offset_x = 0;

                
            }
                
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }


    }
}
