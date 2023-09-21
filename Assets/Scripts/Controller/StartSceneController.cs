using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class StartSceneController : MonoBehaviour
{
    public GameObject nameInputPanel;
    public TMP_InputField nameInput;
    public TMP_Text playerNameText;
    

    private void Start()
    {
        
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            string playerName = PlayerPrefs.GetString("PlayerName");
            nameInput.text = playerName;
        }
    }

    public void ShowNameInputPanel()
    {
        nameInputPanel.SetActive(true);
        
    }

    public void Savename()
    {
        string playerName = nameInput.text;
        
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        nameInputPanel.SetActive(false);
    
    }     
}
