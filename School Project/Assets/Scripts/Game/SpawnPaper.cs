using System.Collections.Generic;
using UnityEngine;

public class SpawnPaper : MonoBehaviour
{
    [SerializeField] private GameObject _paperPrefab;
    [SerializeField] private int _paperCount;
    
    private List<Point> _spawnPoints = new List<Point>();
    private List<GameObject> _papers = new List<GameObject>();

    public int PaperCount 
    {
        set
        {
            if (value % 5 == 0)
                _paperCount = value / 5;
        }
    }

    private void Awake()
    {
        for (int i = 0; i < _paperCount; i++)
        {
            _papers.Add(Instantiate(_paperPrefab));
        }

        _spawnPoints.AddRange(GetComponentsInChildren<Point>());

        foreach (var paper in _papers)
        {
            if (_spawnPoints.Count == 0)
                break;

            var point = _spawnPoints[Random.Range(0, _spawnPoints.Count - 1)];
            paper.transform.position = point.transform.position;
            SetParent(paper, point.GetComponent<Point>().ParentObject);
            _spawnPoints.Remove(point);
        }
    }

    private void SetParent(GameObject childObject,GameObject newParent)
    {
        childObject.transform.parent = newParent.transform;
    }
}
