using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // https://freesfx.co.uk/Category/Money/380

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Sound Effects")]
    public AudioClip click;
    public AudioClip saw;
    public AudioClip uiClick;
    public AudioClip upgrade;
    public AudioClip achievement;

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
