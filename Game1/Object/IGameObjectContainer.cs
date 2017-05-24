using System.Collections.Generic;
using GameObject;

public interface IGameObjectContainer
{
    void add(GameObject.GameObject gameObject);

    void remove(GameObject.GameObject component);

    void clear();

    List<GameObject.GameObject> getAll();
}
