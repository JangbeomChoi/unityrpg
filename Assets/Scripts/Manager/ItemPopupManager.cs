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
            
            popupText.text = "���� �Ͻðڽ��ϱ�?";
        }
        else
        {
            
            popupText.text = "���� �Ͻðڽ��ϱ�?";
            
        }

        itemEquippopupPanel.SetActive(true);
        backgroundPanel.SetActive(true); 
    }

    public void ConfirmAction()
    {
        if (isEquipping)
        {
            // ������ ������ ����ϴ� ������ ���⿡ �߰�
           
            isEquipping = false;
            ShowEIcon(false);
        }
        else
        {
            // �������� �����ϴ� ������ ���⿡ �߰�
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
