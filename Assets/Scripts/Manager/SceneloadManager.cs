using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneloadManager : MonoBehaviour
{
    public enum SceneEnum
    {
        MainScene,
        StartScene,
        CreditScene,
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

    public void ToStart()
    {
        PlayerPrefs.DeleteKey("PlayerName");
        PlayerPrefs.Save();

        SceneloadManager sceneloadManager = FindObjectOfType<SceneloadManager>();
        if (sceneloadManager != null)
        {
            sceneloadManager.Load(SceneloadManager.SceneEnum.StartScene);
        }
    }

    public void ToCredit()
    {
        SceneloadManager sceneloadManager = FindObjectOfType<SceneloadManager>();
        if (sceneloadManager != null)
        {
            sceneloadManager.Load(SceneloadManager.SceneEnum.CreditScene);
        }
    }

}
