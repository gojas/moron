namespace World.Scene.Scenes
{
    using World.Scene;

    public class Scene_1 : Scene
    {
        public override int[] GetGameObjects()
        {
            int[] a = { 0, 1, 2 };

            return a;
        }

        public override int[,] GetGameObjectMatrix()
        {
            int[,] a = {
                {0, 0, 0},
                {1, 0, 1},
                {0, 1, 2},
                {0, 1, 2}
            };

            return a;
        }

        public override string[] GetTextures()
        {
            string[] a = { "cowboy" };

            return a;
        }
    }
    
}
