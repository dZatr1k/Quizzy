using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] private Task[] _tasks;
    [SerializeField] private bool _usePersonalTasks;
    [SerializeField] private int _taskCount = 30;

    private List<Task> _currentTasks = new List<Task>();
    private List<Task> _selectableTasks = new List<Task>();
    private List<Task> _selectablePersonalTasks = new List<Task>();
    private Task[] _personalTasks = new Task[0];
    private Answer[] _answers;
    private Question _question;
    private int _indexRightAnswer;

    public bool UsePersonalTasks 
    {
        get => _usePersonalTasks; 
        
        set
        {
            _usePersonalTasks = value;
        } 
    }

    public int TaskCount
    {
        get => _taskCount;
        set
        {
            if (value >= 0)
                _taskCount = value;
        }
    }

    public List<Task> CurrentTasks => _currentTasks;

    public int IndexRightAnswer => _indexRightAnswer;

    private void Awake()
    {
        _answers = GetComponentsInChildren<Answer>();
        _question = GetComponentInChildren<Question>();

        ResetTasksList();
    }

    public bool TryGenerateCard()
    {
        if (_currentTasks.Count == 0)
        {
            return true;
        }

        GenerateCard();

        return false;
    }

    private void GenerateCard()
    {
        int randomIndex = Random.Range(0, _currentTasks.ToArray().Length - 1);

        _indexRightAnswer = _currentTasks[randomIndex].RightAnswerIndex;

        for (int i = 0; i < 4; i++)
        {
            _answers[i].GetComponentInChildren<TextMeshProUGUI>().text = _currentTasks[randomIndex].Answers[i];
        }

        _question.GetComponent<TextMeshProUGUI>().text = _currentTasks[randomIndex].Question;

        _currentTasks.Remove(_currentTasks[randomIndex]);
    }

    public void ResetTasksList()
    {
        _currentTasks.AddRange(new Task[_taskCount]);

        Debug.Log(_currentTasks.Count);

        if(_usePersonalTasks && _personalTasks != null)
        {
            _selectablePersonalTasks.AddRange(_personalTasks);
        }

        _selectableTasks.AddRange(_tasks);

        for (int i = 0; i < _currentTasks.Count; i++)
        {
            if (Random.Range(1, 2) == 1)
            {
                var j = Random.Range(0, _selectableTasks.Count - 1);
                _currentTasks[i] = _selectableTasks[j];
                _selectableTasks.Remove(_selectableTasks[j]);
            }
            else
            {
                if(_usePersonalTasks && _selectablePersonalTasks != null)
                {
                    var j = Random.Range(0, _selectablePersonalTasks.Count - 1);
                    _currentTasks[i] = _selectablePersonalTasks[j];
                    _selectablePersonalTasks.Remove(_selectablePersonalTasks[j]);
                }
                else
                {
                    var j = Random.Range(0, _selectableTasks.Count - 1);
                    _currentTasks[i] = _selectableTasks[j];
                    _selectableTasks.Remove(_selectableTasks[j]);
                }

            }

        }
    }
}
