using System.Collections.Generic;
using Component.Input;
using Component.Graphic;

namespace Component
{
    public class ComponentContainer : IComponentContainerAware
    {
        private List<AbstractComponent> components = new List<AbstractComponent>();

        public ComponentContainer()
        {
            
        }

        public void add(AbstractComponent component)
        {
            components.Add(component);
        }

        public void remove(AbstractComponent component)
        {
            components.Remove(component);
        }

        public void clear()
        {
            components.Clear();
        }

        public List<AbstractComponent> getAll()
        {
            return components;
        }

        public AbstractComponent getInputComponent()
        {
            return components.Find((AbstractComponent component) =>
            {
                return component is InputComponent;
            });
        }

        public AbstractComponent getGraphicComponent()
        {
            return components.Find((AbstractComponent component) =>
            {
                return component is GraphicComponent;
            });
        }
    }
}
