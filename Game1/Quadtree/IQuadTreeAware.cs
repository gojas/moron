using QuadTree;

public interface IQuadTreeAware
{
    void SetQuadTree(QuadTree.QuadTree quadTree);

    QuadTree.QuadTree GetQuadTree();
}
