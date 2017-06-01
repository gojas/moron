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

        public override int[,] GetTerrainMatrix()
        {
            int[,] a = {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };

            return a;
        }

        protected override void LoadGameObjectMatrix()
        {
            int[,] a = {
                { 1, 1, 1, 1, 3, 3 },
                { 1, 1, 1, 1, 3, 3 },
                { 1, 0, 2, 1, 3, 3 },
                { 1, 1, 1, 1, 3, 3 }
            };

            GameObjectMatrix = a;
        }

        public override string[] GetTextures()
        {
            string[] a = { "cowboy_walking_pistol", "orange_tile_flat", "orange_wall_halfcorner" };

            return a;
        }
    }
    
}
