using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject statusUIPanel;
    
    public Button statusButton;
    public Button inventoryButton;
    
    public void Start()
    {
        statusButton.onClick.AddListener(ShowStatusUI);
       
    }

    public void ShowStatusUI()
    {
        statusUIPanel.SetActive(true);

        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);

    }
    public void CloseStatusUI()
    {
        statusUIPanel.SetActive(false);

        statusButton.gameObject.SetActive(!false);
        inventoryButton.gameObject.SetActive(!false);
    }
   
}
