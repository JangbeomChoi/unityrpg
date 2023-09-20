using UnityEngine;
using UnityEngine.UI;

public class SettingUIManager : MonoBehaviour
{
    public GameObject settingUIPanel;
    public Button settingButton;
    public Button toGameButton;
    // Start is called before the first frame update
    void Start()
    {
        settingButton.onClick.AddListener(ShowSettingUI);
        toGameButton.onClick.AddListener(CloseSettingUI);
    }

    public void ShowSettingUI()
    {
        settingUIPanel.SetActive(true);
    }

    public void CloseSettingUI()
    {
        settingUIPanel.SetActive(false);
    }
}
