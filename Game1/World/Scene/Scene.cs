namespace World.Scene
{
    public class Scene
    {

        public int[,] GameObjectMatrix;

        public Scene()
        {
            
        }


        public virtual int[] GetGameObjects()
        {
            int[] a = { };

            return a;
        }

        public virtual int[] GetTerrainObjects()
        {
            int[] a = { };

            return a;
        }

        public virtual int[,] GetTerrainMatrix()
        {
            int[,] a = { };

            return a;
        }

        public virtual int[,] GetGameObjectMatrix()
        {
            int[,] a = { };

            return a;
        }

        public virtual object[] GetSpriteSheets()
        {
            object[] a = { };

            return a;
        }

    }
}
