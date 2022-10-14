using UnityEngine;

public class LoadVolume : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<Sound>().GetComponent<AudioSource>().volume = DataHolder.SoundVolume;
        FindObjectOfType<Music>().GetComponent<AudioSource>().volume = DataHolder.MusicVolume;
    }
}
