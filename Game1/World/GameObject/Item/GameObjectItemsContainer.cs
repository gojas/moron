using System.Collections.Generic;

namespace World.GameObject.Item
{
    public class GameObjectItemsContainer
    {
        private readonly IDictionary<string, GameObjectItem> itemList;

        public GameObjectItemsContainer()
        {
            itemList = new Dictionary<string, GameObjectItem>();
        }

        public void Add(string name, GameObjectItem gameObject)
        {
            if (!itemList.ContainsKey(name))
                itemList.Add(name, gameObject);
        }

        public GameObjectItem Get(string name)
        {

            return itemList[name];
        }

        public void Remove(string name)
        {
            itemList.Remove(name);
        }

        public IDictionary<string, GameObjectItem> GetAll()
        {
            return itemList;
        }

        public void Clear()
        {
            itemList.Clear();
        }
    }
}
