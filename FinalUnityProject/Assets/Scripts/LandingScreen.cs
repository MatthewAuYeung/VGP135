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
    private Button achivementButton;
    private void Start()
    {
        startGameButton.onClick.AddListener(StartButtonClickdCallback);
        settingButton.onClick.AddListener(SettingButtonClickedCallback);
        contactusButton.onClick.AddListener(ContactUsButtonClickedCallback);
        achivementButton.onClick.AddListener(AchivementButtonClickedCallback);
    }

    private void SettingButtonClickedCallback()
    {
        ScreenManagerScript.Instance().PushScreen("SettingScreen");
    }

    private void ContactUsButtonClickedCallback()
    {
        ScreenManagerScript.Instance().PushScreen("ContactUsScreen");
    }

    private void AchivementButtonClickedCallback()
    {
        ScreenManagerScript.Instance().PushScreen("AchivementScreen");
    }

    private void OnDestroy()
    {
        startGameButton.onClick.RemoveListener(StartButtonClickdCallback);
    }
    private void StartButtonClickdCallback()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
