using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class StartSceneController : MonoBehaviour
{
    public TMP_InputField nameInput;

    private void Start()
    {
        
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            string playerName = PlayerPrefs.GetString("PlayerName");
            nameInput.text = playerName;
        }
    }

    public void Savename()
    {
        string playerName = nameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
       
    }

    //public void StartGame()
    //{
    //    SceneloadManager sceneloadManager = FindObjectOfType<SceneloadManager>();
    //    if(sceneloadManager != null)
    //    {
    //        sceneloadManager.Load(SceneloadManager.SceneEnum.MainScene);
    //    }
       
    //}
    
}
