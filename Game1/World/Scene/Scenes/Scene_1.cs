namespace World.Scene.Scenes
{
    using World.Scene;

    public class Scene_1 : Scene
    {
        public override int[] GetGameObjects()
        {
            int[] a = { 0, 1, 2, 3 };

            return a;
        }

        public override int[] GetTerrainObjects()
        {
            int[] a = { 0 };

            return a;
        }

        public override int[,] GetTerrainMatrix()
        {
            int[,] a = {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            return a;
        }

        public override int[,] GetGameObjectMatrix()
        {
            int[,] a = {
                {0, 2, 2, 3}
            };

            return a;
        }

        public override string[] GetTextures()
        {
            string[] a = { "cowboy_walking_pistol", "orange_tile_2_1", "orange_wall_halfcorner_2_1" };

            return a;
        }
    }
    
}
