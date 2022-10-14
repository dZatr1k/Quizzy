using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menuButtons;
    [SerializeField] private GameObject _difficultyMenu;
    [SerializeField] private GameObject _settingsMenu;

    public void StartGame()
    {
        _difficultyMenu.SetActive(true);
        _menuButtons.SetActive(false);
    }

    public void OpenSettings()
    {
        _settingsMenu.SetActive(true);
        _menuButtons.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
