using World.Scene;

public interface ISceneManagerAware
{
    void SetSceneManager(SceneManager sceneManager);

    SceneManager GetSceneManager();
}
