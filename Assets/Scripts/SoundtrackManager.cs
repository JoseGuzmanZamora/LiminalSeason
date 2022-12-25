using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundtrackManager : MonoBehaviour
{
    public List<AudioClip> clips;
    public int currentClip = 0;
    private AudioSource audioS;

    private void Start() {
        audioS = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        //Debug.Log(audioS.clip.name);
        if (audioS.isPlaying is false)
        {
            audioS.clip = clips[currentClip];
            if (currentClip >= clips.Count - 1)
            {
                currentClip = 0;
            }
            else currentClip++;
            audioS.Play();
        }
    }
}
