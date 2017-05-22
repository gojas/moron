using System.Collections.Generic;
using Component;

public interface IComponentContainerAware
{
    void add(Component.Component component);

    void remove(Component.Component component);

    void clear();

    List<Component.Component> getAll();
}
