using System.Collections.Generic;

using Component.Input;

namespace Object
{
    public class GameObjectContainer 
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
