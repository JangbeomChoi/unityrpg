using TMPro;
using UnityEngine;

public class ItemPopupManager : MonoBehaviour
{
   
    public GameObject itemEquippopupPanel;
    public GameObject eIcon;
    public TMP_Text popupText;
    public GameObject backgroundPanel; 

    private bool isEquipping = false;

    public void ShowPopup(bool isEquipping)
    {
        this.isEquipping = isEquipping;

        if (isEquipping == true)
        {
            
            popupText.text = "해제 하시겠습니까?";
        }
        else
        {
            
            popupText.text = "장착 하시겠습니까?";
            
        }

        itemEquippopupPanel.SetActive(true);
        backgroundPanel.SetActive(true); 
    }

    public void ConfirmAction()
    {
        if (isEquipping)
        {
            // 아이템 장착을 취소하는 로직을 여기에 추가
           
            isEquipping = false;
            ShowEIcon(false);
        }
        else
        {
            // 아이템을 장착하는 로직을 여기에 추가
            isEquipping=true;
            ShowEIcon(true);
            
        }

        ClosePopup();
    }

    public void CancelAction()
    {
        ClosePopup();
    }

    private void ClosePopup()
    {
        itemEquippopupPanel.SetActive(false);
        backgroundPanel.SetActive(false); 
    }

    private void ShowEIcon(bool show)
    {
        eIcon.SetActive(show);
    }

}
