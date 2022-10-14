using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject _settingsMenu;
    [SerializeField] private GameObject _pauseMenu;
    
    private Sound _sound;
    private Music _music;

    private void Awake()
    {
        try
        {
            _sound = FindObjectOfType<Sound>();
            _sound.GetComponent<AudioSource>().volume = DataHolder.MusicVolume;
        }
        catch{}

        _music = FindObjectOfType<Music>();
        _music.GetComponent<AudioSource>().volume = DataHolder.SoundVolume;
    }

    public void Sound(Slider slider)
    {
        try
        {
            _sound.GetComponent<AudioSource>().volume = slider.value;
        }
        catch {}
        DataHolder.SoundVolume = slider.value;
    }

    public void Music(Slider slider)
    {
        _music.GetComponent<AudioSource>().volume = slider.value;
        DataHolder.MusicVolume = slider.value;
    }

    public void Back()
    {
        _pauseMenu.SetActive(true);
        _settingsMenu.SetActive(false);
    }
}
