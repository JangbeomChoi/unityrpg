using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AudioController : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;
    public Toggle audioToggle; // 음소거 토글 추가

    private const string BGMVolumeKey = "BGMVolume";
    private const string AudioMutedKey = "AudioMuted";

    private void Start()
    {
        // PlayerPrefs에서 저장된 설정 값을 읽어와서 UI에 반영
        float savedBGMVolume = PlayerPrefs.GetFloat(BGMVolumeKey, 0f);
        bool audioMuted = PlayerPrefs.GetInt(AudioMutedKey, 0) == 1;

        audioSlider.value = savedBGMVolume;
        audioToggle.isOn = audioMuted;

        // 초기 설정을 적용
        SetBGMVolume(savedBGMVolume);
        SetAudioMuted(audioMuted);
    }

    public void AudioControl()
    {
        float sound = audioSlider.value;

        // 설정 값을 PlayerPrefs에 저장
        PlayerPrefs.SetFloat(BGMVolumeKey, sound);
        PlayerPrefs.Save();

        SetBGMVolume(sound);
    }

    public void ToggleAudioVolume()
    {
        bool audioMuted = audioToggle.isOn;

        // 설정 값을 PlayerPrefs에 저장
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
//{
//    public AudioMixer masterMixer;
//    public Slider audioSlider;

//    public void AudioControl()
//    {
//        float sound = audioSlider.value;

//        if (sound == -40f) masterMixer.SetFloat("BGM", -80);
//        else masterMixer.SetFloat("BGM", sound);
//    }

//    public void ToggleAudioVolume()
//    {
//        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
//    }
//}
