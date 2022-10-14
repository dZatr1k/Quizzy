using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menuButtons;

    public void Close()
    {
        _menuButtons.SetActive(true);
        gameObject.SetActive(false);
    }

    public void StartGame(string timeAndTaskCount)
    {
        DataHolder.Time = int.Parse(timeAndTaskCount.Split(' ')[0]);
        DataHolder.TaskCount = int.Parse(timeAndTaskCount.Split(' ')[1]);

        SceneManager.LoadScene("Game");
    }
}
