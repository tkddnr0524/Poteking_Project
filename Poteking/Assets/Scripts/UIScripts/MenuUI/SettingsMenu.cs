using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu; //���� �޴� �г� ����
    public GameObject pauseMenuUI;
    public Slider masterVolumeSlider; //������ ���� �����̴�
    public Toggle muteToggle; //���Ұ� ���

    private const string MasterVolumeKey = "MasterVolume";
    private const string MuteKey = "Mute";

    private void Start()
    {
        //����� �� �ҷ�����
        LoadSettings();

        //�̺�Ʈ ������ ���
        masterVolumeSlider.onValueChanged.AddListener(SetMasterVolume);
        muteToggle.onValueChanged.AddListener(SetMute);
    }

    public void SetMasterVolume(float volume)
    {
        AudioListener.volume = volume;
        if (volume > 0)
        {
            muteToggle.isOn = false;
        }
        SaveSettings();
    }

    public void SetMute(bool isMuted)
    {
        if (isMuted)
        {
            masterVolumeSlider.value = 0;
            AudioListener.volume = 0;
        }
        else
        {
            masterVolumeSlider.value = 0.5f;
            AudioListener.volume = 0.5f;
        }
        SaveSettings();
    }

    void LoadSettings()
    {
        if (PlayerPrefs.HasKey(MasterVolumeKey))
        {
            float volume = PlayerPrefs.GetFloat(MasterVolumeKey);
            AudioListener.volume = volume;
            masterVolumeSlider.value = volume;
            muteToggle.isOn = volume == 0;
        }
        else
        {
            masterVolumeSlider.value = AudioListener.volume;
            muteToggle.isOn = AudioListener.volume == 0;
        }
    }

    void SaveSettings()
    {
        PlayerPrefs.SetFloat(MasterVolumeKey, AudioListener.volume);
        PlayerPrefs.SetInt(MuteKey, muteToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();
    }




    public void OpenSettings()
    {
        settingsMenu.SetActive(true); //����â Ȱ��ȭ

        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }
    }

    public void CloseSettings()
    {
        settingsMenu.SetActive(false);

        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true);
        }
    }
}
