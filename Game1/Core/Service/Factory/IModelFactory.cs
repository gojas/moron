using Core.Model;

public interface IModelFactory
{
    AbstractModel get(string name);
}
