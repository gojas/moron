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

            foreach (int objectId in objects)
            {
                
            }
        }

        
    }
}
