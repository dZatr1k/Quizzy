using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class CardCheckBox : MonoBehaviour
{
    private Toggle[] _toggles;
    private GameLoop _gameLoop;
    private Color _color;

    private void Awake()
    {
        _toggles = FindObjectsOfType<Toggle>();
        _gameLoop = FindObjectOfType<GameLoop>();
        _color = _toggles[0].GetComponentInChildren<Image>().color;
    }

    public void SetInterectable(bool newValue)
    {
        foreach (var toggle in _toggles)
        {
            toggle.interactable = newValue;
        }
    }

    public void SetEnabled(bool newValue)
    {
        foreach (var toggle in _toggles)
        {
            toggle.isOn = newValue;
        }
    }

    public void ResetColor()
    {
        foreach (var item in _toggles)
        {
            item.GetComponentInChildren<Image>().color = _color;
        }
    }

    public void GetAnswer(Toggle pressedToggle)
    {
        if (_toggles.All(toggle => toggle.isOn == false))
            return;

        if (int.Parse(pressedToggle.name[pressedToggle.name.Length - 1].ToString()) == FindObjectOfType<CardGenerator>().IndexRightAnswer + 1)
        {
            FindObjectOfType<GameLoop>().SolveQuestions = 1;
            pressedToggle.GetComponentInChildren<Image>().color = new Color(0, 255, 0);
        }
        else
        {
            pressedToggle.GetComponentInChildren<Image>().color = new Color(255, 0, 0);
        }

        StartCoroutine(_gameLoop.EndLoop());
    }
}
