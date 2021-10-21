using UnityEngine;
using System.Collections;

public class MyAudioPlay : MonoBehaviour {

//	public AudioClip clip;


	void OnCollisionEnter(Collision collision)
	{
		GetComponent<AudioSource>().Play();

		Destroy(this.gameObject); //오디오가 플레이 되면서 바로 오브젝트가 삭제되서 소리가 안들림 
	}

}
