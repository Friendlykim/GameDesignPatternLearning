using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipPlay : MonoBehaviour
{
	public AudioClip clip;

	void OnCollisionEnter(Collision collision)
	{
		AudioManager.Instance().Play(clip);

		Destroy(this.gameObject);
	}

}
