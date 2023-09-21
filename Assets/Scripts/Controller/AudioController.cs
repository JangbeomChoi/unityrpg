using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AudioController : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;
    public Toggle audioToggle; 

    private const string BGMVolumeKey = "BGMVolume";
    private const string AudioMutedKey = "AudioMuted";

    private void Start()
    {
        
        float savedBGMVolume = PlayerPrefs.GetFloat(BGMVolumeKey, 0f);
        bool audioMuted = PlayerPrefs.GetInt(AudioMutedKey, 0) == 1;

        audioSlider.value = savedBGMVolume;
        audioToggle.isOn = audioMuted;

        
        SetBGMVolume(savedBGMVolume);
        SetAudioMuted(audioMuted);
    }

    public void AudioControl()
    {
        float sound = audioSlider.value;

        
        PlayerPrefs.SetFloat(BGMVolumeKey, sound);
        PlayerPrefs.Save();

        SetBGMVolume(sound);
    }

    public void ToggleAudioVolume()
    {
        bool audioMuted = audioToggle.isOn;

        
        PlayerPrefs.SetInt(AudioMutedKey, audioMuted ? 1 : 0);
        PlayerPrefs.Save();

        SetAudioMuted(audioMuted);
    }

    private void SetBGMVolume(float volume)
    {
        if (volume == -40f) masterMixer.SetFloat("BGM", -80);
        else masterMixer.SetFloat("BGM", volume);
    }

    private void SetAudioMuted(bool muted)
    {
        AudioListener.volume = muted ? 0 : 1;
    }
}

