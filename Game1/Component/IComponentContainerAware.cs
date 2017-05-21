using System.Collections.Generic;
using Component;

public interface IComponentContainerAware
{
    void add(AbstractComponent component);

    void remove(AbstractComponent component);

    void clear();

    List<AbstractComponent> getAll();
}
