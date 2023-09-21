using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayManager : MonoBehaviour
{
    private AudioSource audioSource;
    private GameObject[] musics;

    private void Awake()
    {
        musics = GameObject.FindGameObjectsWithTag("BGM");
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }
    public void StopMusic()
    {
        audioSource.Stop();
    }
}
