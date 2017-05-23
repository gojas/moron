using Object;

namespace Component
{
    public class Component : IComponent
    {
        public virtual void update(GameObject gameObject) {

        }

        public virtual void update(GameObject gameObject, QuadTree.QuadTree quadTree)
        {

        }
    }
}
