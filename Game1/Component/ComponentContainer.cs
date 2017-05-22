using System.Collections.Generic;

namespace Component
{
    public class ComponentContainer : IComponentContainerAware
    {
        private List<Component> components = new List<Component>();

        public ComponentContainer()
        {
            
        }

        public void add(Component component)
        {
            components.Add(component);
        }

        public void remove(Component component)
        {
            components.Remove(component);
        }

        public void clear()
        {
            components.Clear();
        }

        public List<Component> getAll()
        {
            return components;
        }

        public Component getInputComponent()
        {
            return components.Find((Component component) =>
            {
                return component is InputComponent;
            });
        }

        public Component getGraphicComponent()
        {
            return components.Find((Component component) =>
            {
                return component is GraphicComponent;
            });
        }

        public Component getPhysicsComponent()
        {
            return components.Find((Component component) =>
            {
                return component is PhysicsComponent;
            });
        }
    }
}
