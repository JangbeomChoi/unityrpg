using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AudioController : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;
    public Toggle audioToggle; // ���Ұ� ��� �߰�

    private const string BGMVolumeKey = "BGMVolume";
    private const string AudioMutedKey = "AudioMuted";

    private void Start()
    {
        // PlayerPrefs���� ����� ���� ���� �о�ͼ� UI�� �ݿ�
        float savedBGMVolume = PlayerPrefs.GetFloat(BGMVolumeKey, 0f);
        bool audioMuted = PlayerPrefs.GetInt(AudioMutedKey, 0) == 1;

        audioSlider.value = savedBGMVolume;
        audioToggle.isOn = audioMuted;

        // �ʱ� ������ ����
        SetBGMVolume(savedBGMVolume);
        SetAudioMuted(audioMuted);
    }

    public void AudioControl()
    {
        float sound = audioSlider.value;

        // ���� ���� PlayerPrefs�� ����
        PlayerPrefs.SetFloat(BGMVolumeKey, sound);
        PlayerPrefs.Save();

        SetBGMVolume(sound);
    }

    public void ToggleAudioVolume()
    {
        bool audioMuted = audioToggle.isOn;

        // ���� ���� PlayerPrefs�� ����
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
