using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EIcon : MonoBehaviour
{
    public GameObject eIcon;
    public void UpdateEIcon(bool isEquipped)
    {
        eIcon.SetActive(isEquipped);
    }
}
