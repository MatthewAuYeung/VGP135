using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandingScreen : MonoBehaviour
{

    [SerializeField]
    private Button startGameButton;
    [SerializeField]
    private Button settingButton;
    [SerializeField]
    private Button contactusButton;
    [SerializeField]
    private Button achivmentButton;
    private void Start()
    {
        startGameButton.onClick.AddListener(StartButtonClickdCallback);
        settingButton.onClick.AddListener(SettingButtonClickedCallback);
    }

    private void SettingButtonClickedCallback()
    {
        ScreenManagerScript.Instance().PushScreen("SettingScreen");
    }

    private void OnDestroy()
    {
        startGameButton.onClick.RemoveListener(StartButtonClickdCallback);
    }
    private void StartButtonClickdCallback()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
