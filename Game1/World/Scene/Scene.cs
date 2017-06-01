namespace World.Scene
{
    public class Scene
    {

        public int[,] GameObjectMatrix;

        public Scene()
        {
            LoadGameObjectMatrix();
        }


        public virtual int[] GetGameObjects()
        {
            int[] a = { };

            return a;
        }

        public virtual int[,] GetTerrainMatrix()
        {
            int[,] a = { };

            return a;
        }

        protected virtual void LoadGameObjectMatrix()
        {

        }

        public virtual string[] GetTextures()
        {
            string[] a = { };

            return a;
        }

        public void ChangeGameObjectMatrix(int x, int y, int gameObjectId)
        {
            GameObjectMatrix[x, y] = gameObjectId;
        }

    }
}
