using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    int myPoint = 0;

    static AudioManager _instance = null;
    public static AudioManager Instance()
    {
        return _instance;
    }

    void Start()
    {
        if (_instance == null)
            _instance = this;
    }

    public void Play(AudioClip Clip)
    {
        GetComponent<AudioSource>().PlayOneShot(Clip);
    }

    public int GetPoint()
    {
        myPoint = myPoint + 1;
        return myPoint;
    }
}
