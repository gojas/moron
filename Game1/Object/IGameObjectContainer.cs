using System.Collections.Generic;
using Object;

public interface IGameObjectContainer
{
    void add(GameObject gameObject);

    void remove(GameObject component);

    void clear();

    List<GameObject> getAll();
}
