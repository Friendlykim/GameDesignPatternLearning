using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 pos = new Vector3(0f, 4f, 0f);
            Instantiate(ball, pos, Quaternion.identity);
        }
    }
}
