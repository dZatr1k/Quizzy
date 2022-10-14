using UnityEngine;

public class LoadDifficult : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<Timer>().TimeWatch = DataHolder.Time * 60;
        FindObjectOfType<CardGenerator>().TaskCount = DataHolder.TaskCount;
        FindObjectOfType<SpawnPaper>().PaperCount = DataHolder.TaskCount;
    }
}
