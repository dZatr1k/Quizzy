using UnityEngine;

[CreateAssetMenu(fileName = "New task", menuName = "Task/Create New Task", order = 51)]
public class Task : ScriptableObject
{
    [SerializeField] private string _question;
    [SerializeField] private string[] _answers;
    [SerializeField] private int _rightAnswerIndex;

    public string Question => _question;
    public string[] Answers => _answers;
    public int RightAnswerIndex => _rightAnswerIndex;
}
