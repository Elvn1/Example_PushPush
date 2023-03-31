using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Example_DoTween_SetFloat : MonoBehaviour
{
    public AudioSource audioSource;
    public float audioVolume;

    void Start()
    {
        DOTween.Init();
        audioSource.outputAudioMixerGroup.audioMixer.DOSetFloat("BGM", 0, 3f);
    }
}
