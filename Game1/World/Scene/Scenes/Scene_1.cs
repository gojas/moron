namespace World.Scene.Scenes
{
    using World.Scene;

    public class Scene_1 : Scene
    {
        public override int[] GetGameObjects()
        {
            int[] a = { 0, 1, 2, 3, 6, 7};

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
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},


            };

            return a;
        }

        public override int[,] GetGameObjectMatrix()
        {
            int[,] a = {
                {0, 1, 7, 1},
                {7, 7, 7, 1},
                {7, 7, 6, 2},
                {7, 7, 7, 1},
                {7, 7, 7, 2},
                {6, 6, 6, 8},
            };

            return a;
        }

        public override string[] GetTextures()
        {
            string[] a = { "cowboy_walking_pistol", "orange_tile_2_1", "orange_wall_halfcorner_2_1", "arrow_2_2", "grass_flowers", "grass", "barrel", "explosion" };

            return a;
        }
    }
    
}
