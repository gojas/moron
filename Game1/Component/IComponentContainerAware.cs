using System.Collections.Generic;
using Component;

public interface IComponentContainerAware
{
    void Add(Component.Component component);

    void Remove(Component.Component component);

    void Clear();

    List<Component.Component> GetAll();
}
