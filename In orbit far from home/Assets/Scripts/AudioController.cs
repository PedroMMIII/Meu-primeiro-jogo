using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioSource audioSourceSFX;  
    public AudioClip[] musicaDeFundo;
    // Start is called before the first frame update
    void Start()
    {
        int IndexDaMusicaDeFundo = Random.Range(0, musicaDeFundo.Length);
        AudioClip musicaDeFundoDessaFase = musicaDeFundo[IndexDaMusicaDeFundo];
        audioSourceMusicaDeFundo.clip = musicaDeFundoDessaFase;
        audioSourceMusicaDeFundo.loop = true;
        audioSourceMusicaDeFundo.Play();
    }

    public void ToqueSFX(AudioClip clip) 
    {
        audioSourceSFX.PlayOneShot(clip);
    }
}
