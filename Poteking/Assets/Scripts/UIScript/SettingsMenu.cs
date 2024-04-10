using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu; //세팅 메뉴 패널 공간
    public void OnSettingsMenuPanel()
    {
        settingsMenu.SetActive(true);
    }

    public void CloseSettingsMenuPanel()
    {
        settingsMenu.SetActive(false);
    }
}
