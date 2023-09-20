using TMPro;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    public TMP_Text playerNameText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            string playerName = PlayerPrefs.GetString("PlayerName");
            
            playerNameText.text = playerName;
        }
        else
        {
            playerNameText.text = "NA";
        }
    }
}
