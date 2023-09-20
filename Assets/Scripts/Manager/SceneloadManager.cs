using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneloadManager : MonoBehaviour
{
    public enum SceneEnum
    {
        MainScene,
        StartScene,
    }
    public void Load(SceneEnum nextScene)
    {
        string sceneName = nextScene.ToString();
        SceneManager.LoadScene(sceneName);
    }

    public void StartGame()
    {
        SceneloadManager sceneloadManager = FindObjectOfType<SceneloadManager>();
        if (sceneloadManager != null)
        {
            sceneloadManager.Load(SceneloadManager.SceneEnum.MainScene);
        }

    }

}
