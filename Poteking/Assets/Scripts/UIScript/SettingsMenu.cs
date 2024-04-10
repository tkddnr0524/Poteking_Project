using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu; //���� �޴� �г� ����
    public void OnSettingsMenuPanel()
    {
        settingsMenu.SetActive(true);
    }

    public void CloseSettingsMenuPanel()
    {
        settingsMenu.SetActive(false);
    }
}
