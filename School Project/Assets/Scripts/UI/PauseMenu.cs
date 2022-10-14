using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _settings;

    private bool _isOpen = false;

    public void SetActive()
    {
        _isOpen = !_isOpen;
        if (_isOpen)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
        _pauseMenu.SetActive(_isOpen);
    }

    public void CloseMenu()
    {
        SetActive();
    }

    public void OpenSettings()
    {
        _settings.SetActive(true);
        _pauseMenu.SetActive(false);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
