namespace Component
{
    using GameObject;
    using QuadTree;

    public class Component : IComponent
    {
        public virtual void update(GameObject gameObject) {

        }

        public virtual void update(GameObject gameObject, QuadTree quadTree)
        {

        }
    }
}
