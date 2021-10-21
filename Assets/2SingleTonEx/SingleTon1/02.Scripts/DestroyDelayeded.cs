using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelayeded : MonoBehaviour
{

    private AudioSource MyAudio;
    // Start is called before the first frame update
    void Start()
    {
        MyAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        MyAudio.Play();

        Destroy(gameObject, MyAudio.clip.length); // 오디오클립 길이만큼 딜레이 주기
    }
}
