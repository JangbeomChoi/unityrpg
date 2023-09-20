using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{
    public GameObject inventoryUIPanel;
    public Button statusButton;
    public Button inventoryButton;

    void Start()
    {
        inventoryButton.onClick.AddListener(ShowInventoryUI);
    }

    public void ShowInventoryUI()
    {
        inventoryUIPanel.SetActive(true);

        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);

    }
    public void CloseInventoryUI()
    {
        inventoryUIPanel.SetActive(false);

        statusButton.gameObject.SetActive(!false);
        inventoryButton.gameObject.SetActive(!false);
    }

}
