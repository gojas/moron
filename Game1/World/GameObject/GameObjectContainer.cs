namespace World.GameObject
{
    using System.Collections.Generic;
    
    public class GameObjectContainer
    {
        private readonly IDictionary<int, GameObject> objectList;

        public GameObjectContainer()
        {
            objectList = new Dictionary<int, GameObject>();
        }

        public void Add(int id, GameObject gameObject)
        {
            if (!Exists(id))
                objectList.Add(id, gameObject);
        }

        public GameObject Get(int id)
        {
            return objectList[id];
        }

        public void Remove(int id)
        {
            objectList.Remove(id);
        }

        public IDictionary<int, GameObject> GetAll()
        {
            return objectList;
        }

        public void Clear()
        {
            objectList.Clear();
        }

        public bool Exists(int id)
        {
            return objectList.ContainsKey(id);
        }

    }
}
