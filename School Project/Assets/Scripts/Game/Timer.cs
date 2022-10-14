using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTime;
    
    private int _time;

    public int TimeWatch 
    { 
        get => _time;
        set
        {
            if (value >= 0)
                _time = value;
        }
    }
    private void Start() 
    {
        StartCoroutine(CountTime());
    }

    private IEnumerator CountTime()
    {
        while(true)
        {
            if (_time <= 0)
                break;

            yield return new WaitForSeconds(1f);

            _time--;

            _textTime.text = string.Format("{00}:{01}", Mathf.Floor(_time / 60), _time % 60 >= 10 ? (_time % 60).ToString() : '0' + (_time % 60).ToString());
        }

        FindObjectOfType<LoseMenu>().LoseHandle();
    }
}
