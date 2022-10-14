using System.Collections;
using UnityEngine;
using TMPro;

public class GameLoop : MonoBehaviour
{
    private Card _card;
    private CardAnimation _animation;
    private CardCheckBox _checkBox;
    private CardGenerator _generator;
    private int _solvedQuestions;
    private int _iterationCount = 0;

    public int SolveQuestions
    {
        get => _solvedQuestions;
        set
        {
            _solvedQuestions += value == 1 ? value : 0;
        }
    }

    private void Start()
    {
        _solvedQuestions = 0;
        _card = FindObjectOfType<Card>();
        _animation = _card.GetComponent<CardAnimation>();
        _checkBox = FindObjectOfType<CardCheckBox>();
        _generator = _card.GetComponent<CardGenerator>();

        _checkBox.SetInterectable(false);
        _card.gameObject.SetActive(false);
    }

    public IEnumerator StartLoop()
    {
        _card.gameObject.SetActive(true);
        if (_iterationCount == 5 || _generator.TryGenerateCard())
        {
            _iterationCount = 0;
            StopLoop();
            StopAllCoroutines();
        }
        _animation.PlaySlide1();
        yield return new WaitForSeconds(0.5f);

        _checkBox.SetInterectable(true);
    }

    public IEnumerator EndLoop()
    {
        _checkBox.SetInterectable(false);
        yield return new WaitForSeconds(0.1f);

        _animation.PlaySlide2();
        yield return new WaitForSeconds(0.5f);

        _checkBox.SetEnabled(false);
        _checkBox.ResetColor();
        _iterationCount++;
        StartCoroutine(StartLoop());
    }

    private void StopLoop()
    {
        if (_generator.CurrentTasks.Count == 0)
        {
            FindObjectOfType<WinMenu>().WinHandle(_solvedQuestions);
        }

        FindObjectOfType<PlayerMover>().IsMoveLocked = false;

        _card.gameObject.SetActive(false);
    }
}
