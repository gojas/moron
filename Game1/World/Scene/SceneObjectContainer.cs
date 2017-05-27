using System.Collections.Generic;

namespace World.Scene
{
    using World.GameObject;

    public class SceneObjectContainer
    {
        private readonly List<GameObject> objectList;

        public SceneObjectContainer()
        {
            objectList = new List<GameObject>();
        }

        public void Add(GameObject gameObject)
        {
            objectList.Add(gameObject);
        }

        public List<GameObject> GetAll()
        {
            return objectList;
        }

        public void Clear()
        {
            objectList.Clear();
        }
    }
}
