using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalPanel : MonoBehaviour
{
    public GameObject ModalPanelObject;

    private static ModalPanel instance;

    public static ModalPanel GetInstance()
    {
        if (!instance)
        {
            instance = FindObjectOfType<ModalPanel>();

            if (!instance)
            {
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
            }
        }

        return instance;
    }

    public void OpenModal()
    {
        ModalPanelObject.SetActive(true);
    }

    public void CloseModal()
    {
        ModalPanelObject.SetActive(false);
    }
}
