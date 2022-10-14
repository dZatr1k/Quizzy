using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinMenu : MonoBehaviour
{
    [SerializeField] private GameObject _children;
    [SerializeField] private TextMeshProUGUI _text;

    public void WinHandle(int points)
    {
        Time.timeScale = 0;
        _children.SetActive(true);
        FindObjectOfType<PlayerInput>().IsPauseMenuLocked = true;
        _text.text = "Количество правильных ответов: " + points;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void ExitToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
