using System.Collections.Generic;

namespace GameObject
{

    public class GameObjectContainer : IGameObjectContainer
    {
        private List<GameObject> objectList = new List<GameObject>();

        public GameObjectContainer()
        {

        }

        public void add(GameObject gameObject)
        {
            objectList.Add(gameObject);
        }

        public void remove(GameObject gameObject)
        {
            objectList.Remove(gameObject);
        }

        public void clear()
        {
            objectList.Clear();
        }

        public List<GameObject> getAll()
        {
            return objectList;
        }
    }
}
