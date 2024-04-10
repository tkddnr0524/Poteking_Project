using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject soundPanel;

    public void OpenSoundPanel()
    {
        soundPanel.SetActive(true);
    }

}
