namespace Component
{
    using World.GameObject;
    using QuadTree;
    using World.Scene;

    public class ArrowSpawnScriptComponent : ScriptComponent
    {
        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {
            GameObject arrow = sceneManager.GameObjectManager.Get(5); // arrow

            arrow.position.X = gameObject.position.X;
            arrow.position.Y = gameObject.position.Y;
            gameObject.depth = 0.6f;
            sceneManager.GameObjectManager.List.Add(arrow);
        }
    }
}
